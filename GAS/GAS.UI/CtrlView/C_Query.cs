using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GAS.BLL;
using ZedGraph;

namespace GAS.UI.CtrlView
{
    public partial class C_Query : UserControl
    {
        IDAL DALFunc;
        DataSet dataset = new DataSet();
        
        public C_Query()
        {
            InitializeComponent();
        }

        private void C_Query_Load(object sender, EventArgs e)
        {
            dataset = DALFunc.QueryTable("EquipTypeAbl");
            string num= dataset.Tables[0].Rows[1].ToString();
            for(int i=0;i<int.Parse(num);i++)
            {
                cbox1.Items.Add(i+"#设备");
            }

            SetSize();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            //////查询
            SetGragh(zg1);
        }

        /// <summary>
        /// zedgragh作图
        /// </summary>
        /// <param name="zg"></param>
        private void SetGragh(ZedGraph.ZedGraphControl zg)
        {
            GraphPane myPane = zg.GraphPane;
            //Set labels
            myPane.Title.Text = "煤气实绩";// 表头
            myPane.XAxis.Title.Text = "时间";// 横坐标lable
            myPane.YAxis.Title.Text = "煤气量";// 纵坐标label
            //Set list
            PointPairList list = new PointPairList();
            /*            List<HRGasReal> tempList = vList.ToList();
            
                        for (int i = 0; i < 100; i++)
                        {
                            double C = tempList[i].Consumption;
                            DateTime T = tempList[i].Time;

                            double x = Convert.ToDouble(i);
                            double y = Convert.ToDouble(C);
                            list.Add(x, y);
                        }
            */
            /*//DateTime m = Convert.ToDateTime(DG1.Columns[1]);
            Double n = Convert.ToDouble( DG1.Columns[2]);
            list.Add(m, n);
            for (int i = 0; i < 100; i++)
            {
                double x = (double)new XDate(2013, 6,11,i,0,0);
                
                double y = Math.Sin((double)i * Math.PI / 15.0); 

                list.Add(x, y);
            }*/

            // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
            LineItem myCurve = myPane.AddCurve("煤气量", list, Color.Blue, SymbolType.Circle);
            // Fill the area under the curve with a white-red gradient at 45 degrees
            myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            // Make the symbols opaque by filling them with white
            myCurve.Symbol.Fill = new Fill(Color.White);
            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
            //Calculate the Axis Scale Ranges
            //myPane.XAxis.Type = AxisType.Date;

            myPane.AxisChange();
        }


        /// <summary>
        /// zedgragh大小设置
        /// </summary>
        private void SetSize()
        {
            zg1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zg1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 20);
        }

        
    }
}
