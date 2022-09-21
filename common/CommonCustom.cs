using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailController.common
{
    public static class CommonCustom
    {
        public static List<string> getMailChecked(DataGridView dataGridView)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                DataGridViewRow row = dataGridView.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    list.Add(row.Cells[1].Value.ToString());
            }
            return list;
        }

        public static Color SelectThemeColor()
        {
            int tempIndex;
            List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};
            Random random = new Random();
            int index = random.Next(ColorList.Count);
            string color = ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        public static CheckBox addHeaderCheckbox(DataGridView dataGridView)
        {
            CheckBox headerChk = new CheckBox();
            headerChk.Size = new Size(15, 15);
            dataGridView.Controls.Add(headerChk);
            DataGridViewHeaderCell header = dataGridView.Columns[0].HeaderCell;
            headerChk.Location = new Point(
            (header.ContentBounds.Left +
             (header.ContentBounds.Right - header.ContentBounds.Left + headerChk.Size.Width)
             / 2) - 2,
            (header.ContentBounds.Top +
             (header.ContentBounds.Bottom - header.ContentBounds.Top + headerChk.Size.Height)
             / 2) - 2);
            return headerChk;
        }

        public static void headerCheckBoxClick(CheckBox checkBox, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[0].Value = checkBox.Checked;
            }
            dataGridView.RefreshEdit();
        }



    }
}

