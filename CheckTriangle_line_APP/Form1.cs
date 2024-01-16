using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckTriangle_line_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChkButton_1_Click(object sender, EventArgs e)
        {

            int typeNumber = CheckFunctionClass.Triangle_Type
             (
                    (int)numericUpDown1_length.Value,
                    (int)numericUpDown1_High.Value,
                   (int)numericUpDown1_Width.Value
                );

            switch (typeNumber)
            {
                case (int)TriangleEnum.Error_Triangle:

                    label_Answers.Text = "輸入異常";

                    break;
                case (int)TriangleEnum.Right_Triangle:
                    label_Answers.Text = "直角三角形常";
                    break;
                case (int)TriangleEnum.Equilateral_Triangle:
                    label_Answers.Text = "正三角形常";
                    break;
                case (int)TriangleEnum.Isosceles_Triangle:
                    label_Answers.Text = "等腰三角形常";
                    break;
                case (int)TriangleEnum.Others_Triangle:
                    label_Answers.Text = "其它三角形常";
                    break;
                default:
                    label_Answers.Text = "其它三角形常";
                    break;
            }
        }
    }
}