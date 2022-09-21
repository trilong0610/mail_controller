using MailKit.Net.Imap;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailController.model;
using MailKit;

namespace MailController.services
{
    public class MailRepository
    {
        public async Task<List<ModelMail>> GetUnreadMail(string mailServer, int port, string login, string password)
        {
            var messages = new List<ModelMail>();

            using (var client = new ImapClient())
            {
                await client.ConnectAsync(mailServer, port, true);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                await client.AuthenticateAsync(login, password);
                var inbox = client.Inbox;

                await inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);
                SearchQuery queryNotGMailLabelSocial = SearchQuery.Not(SearchQuery.HasGMailLabel("Social"));
                SearchQuery queryNotGMailLabelPromotions = SearchQuery.Not(SearchQuery.HasGMailLabel("Promotions"));
                SearchQuery queryNotGMailLabel = SearchQuery.And(queryNotGMailLabelSocial, queryNotGMailLabelPromotions);
                //var result = await inbox.SearchAsync(SearchOptions.All, SearchQuery.And(queryNotGMailLabel, SearchQuery.NotSeen));
                var result = await inbox.SearchAsync(SearchOptions.All, SearchQuery.And(queryNotGMailLabel, SearchQuery.NotSeen));
                foreach (var uniqueId in result.UniqueIds)
                {
                    var message = await inbox.GetMessageAsync(uniqueId);
                    /*
                        0 Delivered-To: trann.nguyenn.0610@gmail.com
                        1 Received: by 2002:adf:a141:0:0:0:0:0 with SMTP id r1csp1025598wrr;        Thu, 1 Oct 2020 20:30:32 -0700 (PDT)
                        2 X-Google-Smtp-Source: ABdhPJzOqxVChSmR88OxvdB800Jd5MSyhHybcgxJhPmFF80rJm7zQBIMqyci4hGpgO67WcTfaBrL
                        3 X-Received: by 2002:a63:1162:: with SMTP id 34mr111624pgr.329.1601609432477;        Thu, 01 Oct 2020 20:30:32 -0700 (PDT)
                        4 ARC-Seal: i=1; a=rsa-sha256; t=1601609432; cv=none;        d=google.com; s=arc-20160816;        b=T8HbRLyesh0/lc63tlgenK4j0IA0FwUzTiNpCT9+0rXvbnOzgvmnt7P4OkAbcBG7mC         tFDDMe56J9XfrZfZE47FupU99/mbSNxBbeLlOz3QNs5pk77VAFaGsiqX3DpCUptdjGRc         YCVYMBM5iVll9VXjgqggosjf2Ja3013I5u+caLY4i7jsN+slBp2ATf23OdQ/pWGzOaIE         pEsdgfIE9Vbamm95+AWlUqnWvrurlp0bkS9P8oR/OoGxaYF+quSgRCfr4F8ARjDvHQPG         o6AwCrEiYWpNu4rhGFsG3M/yHr29EjDMjA4hd739m3F3g1WLhn85vHrFUwoH+/r1SkB+         jy2Q==
                        5 ARC-Message-Signature: i=1; a=rsa-sha256; c=relaxed/relaxed; d=google.com; s=arc-20160816;        h=feedback-id:message-id:mime-version:subject:to:from:date         :dkim-signature;        bh=988qMvdmC703ioe0CQ3QQAauJ3E2rKRAFAM9YiAt9Jk=;        b=NoWrFvBGQcUudhVaD2VkMhf6DzyG8uZy0hgSOmSz4iD/pIDY4ZuWvSRjIkBGb8eKvF         VQemHmxrx5hrhrjpQjZdzAXRxvv45AEsGp+hJnmj4NMCj0aLTrNgqiqy/QHUug8evCYC         lIvBULexCDn/qemDtcetyMUGnZ3ZXQsJQNy5FJKmMooc7pNlKuFhmc9Z0op3c696Ukot         KheBPWSEd+/ybGDvlUcpM7HHk2Jbnrq/14RmFFPbI8Wr+JVSsKWesZqB/XaBW2sDXBab         ERuN8fcWoPC4GSvKma4aAr/du4QRTjAFE8ZCfSNlzU73DTw70m1CIlpTtQtBlYMoviwm         ymiA==
                        6 ARC-Authentication-Results: i=1; mx.google.com;       dkim=pass header.i=@twitter.com header.s=dkim-201406 header.b=uc7jfNEP;       spf=pass (google.com: domain of b05372b0afdtrann.nguyenn.0610=gmail.com@bounce.twitter.com designates 199.59.150.124 as permitted sender) smtp.mailfrom="b05372b0afdtrann.nguyenn.0610=gmail.com@bounce.twitter.com";       dmarc=pass (p=REJECT sp=REJECT dis=NONE) header.from=twitter.com
                        7 Return-Path: <b05372b0afdtrann.nguyenn.0610=gmail.com@bounce.twitter.com>
                        8 Received: from spruce-goose-cc.twitter.com (spruce-goose-cc.twitter.com. [199.59.150.124])        by mx.google.com with ESMTPS id w18si355912pfu.32.2020.10.01.20.30.31        for <trann.nguyenn.0610@gmail.com>        (version=TLS1_2 cipher=ECDHE-ECDSA-AES128-GCM-SHA256 bits=128/128);        Thu, 01 Oct 2020 20:30:32 -0700 (PDT)
                        9 Received-SPF: pass (google.com: domain of b05372b0afdtrann.nguyenn.0610=gmail.com@bounce.twitter.com designates 199.59.150.124 as permitted sender) client-ip=199.59.150.124;
                        10 Authentication-Results: mx.google.com;       dkim=pass header.i=@twitter.com header.s=dkim-201406 header.b=uc7jfNEP;       spf=pass (google.com: domain of b05372b0afdtrann.nguyenn.0610=gmail.com@bounce.twitter.com designates 199.59.150.124 as permitted sender) smtp.mailfrom="b05372b0afdtrann.nguyenn.0610=gmail.com@bounce.twitter.com";       dmarc=pass (p=REJECT sp=REJECT dis=NONE) header.from=twitter.com
                        11 DKIM-Signature: v=1; a=rsa-sha256; c=relaxed/relaxed; d=twitter.com;	s=dkim-201406; t=1601609431;	bh=988qMvdmC703ioe0CQ3QQAauJ3E2rKRAFAM9YiAt9Jk=;	h=Date:From:To:Subject:MIME-Version:Content-Type:Message-ID;	b=uc7jfNEPjU34aX1yszrHC9b0uJ11+adjElazD0xhR5qfBQP7/+y9iERudaxJ9POWx	 XR0hsHtscm0Ey1Fgh3Z4Gf3olueD79GauGEMbmoeg8hDbOzo7f9dfsq+1jfzjxpdsG	 ajW+T0Xqzg0VSfgb0QXi9Klv2rZHGavrL3kjX634bBZ4+SPwscUuHwwqyBBjj4HEBh	 I+cU6Zt33u6qxRi7TN1Zn8AmyThPhqFbhkixIs/JfmcGhOauOFUNvpfkU28Jb0UF1R	 is7j5vc36M8qoFPZkH6DS5bCWJ7J6u51rtDyWMdr40Ssm5wJRzcwUz03kdpgTo0+oy	 uUxB1qaNtzbBA==
                        12 X-MSFBL: NJAjkZDyM6nXndJKwryGEzlW45slPFi2xqUzeV3O83A=|eyJ1IjoidHJhbm4ubmd	1eWVubi4wNjEwQGdtYWlsLmNvbUBpaWQjIzgxZTYxYzcyOTcyNzQ2MmI4MzQ0ZTh	kMTZjMzk2YjlmQHVzYiMjMjRAMjk2QDEwNDQzMTUxOTk4NzkyMjk0NDFAMEA5MDh	mMTU5MjFhMmU5Yjg0NzE4NmQ2MzJkOTk0MDBmZDExY2NjNjJjIiwiciI6InRyYW5	uLm5ndXllbm4uMDYxMEBnbWFpbC5jb20iLCJiIjoic21mMS1iaGstMjAtc3IxLUN	yaXRpY2FsLjIxNCIsImciOiJDcml0aWNhbCJ9
                        13 Date: Fri, 02 Oct 2020 03:30:31 +0000
                        14 From: Twitter <verify@twitter.com>
                        15 To: Twitter User <trann.nguyenn.0610@gmail.com>
                        16 Subject: 215721 là mã xác nh?n Twitter c?a b?n
                        17 MIME-Version: 1.0
                        18 Message-ID: <DD.CB.53954.7DE967F5@twitter.com>
                        19 Feedback-ID: smf1.2b638e6cf11da985c1e576937311d2b5:Twitter
                    */
                    //messages.Add(message.Subject.ToString());

                    string from = message.From[0].ToString().Split('<')[0];
                    from = from.Replace('"', ' ');
                    string to = login.Split('@')[0];
                    string body = message.TextBody;
                    //string to = message.Sender.ToString();
                    var mail = new ModelMail(Convert.ToInt32(uniqueId.Id), message.Date.UtcDateTime, message.Subject, from, to, body);

                    messages.Add(mail);

                }

                await client.DisconnectAsync(true);
            }

            
            messages = messages.OrderByDescending(p => p.timeReceiver).ToList();
            return messages;
        }

        

    }
}
