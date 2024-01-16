using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTriangle_line_APP
{


    enum TriangleEnum
    {
        Error_Triangle = 0,
        Right_Triangle,
        Equilateral_Triangle,
        Isosceles_Triangle,
        Others_Triangle
    }


    class CheckFunctionClass
    {
        /// <summary>
        ///   0=輸入資料錯誤
        ///   1=直角三角形
        ///   2=等腰三角形
        ///   3=正三角形
        ///   4= 其它三角形
        /// </summary>
        /// <param name="length"></param>
        /// <param name="high"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        static public int Triangle_Type(int length, int high, int width)
        {
            int type = 0;
            if (length == 0 || high == 0 || width == 0)
            {
                type = (int)TriangleEnum.Error_Triangle;
            }
            else if (length == high && length == width)
            {
                type = (int)TriangleEnum.Equilateral_Triangle;
            }
            else if (length == high || length == width || high == width)
            {
                type = (int)TriangleEnum.Isosceles_Triangle; ;
            }
            else if (
                (length * length == (high * high + width * width)) ||
                (width * width == (high * high + length * length)) ||
                (high * high == (length * length + width * width))
                )
            {
                type = (int)TriangleEnum.Right_Triangle;
            }
            else if (length > 0 && width > 0 && high > 0)
            {
                type = (int)TriangleEnum.Others_Triangle;
            }

            return type;
        }




    }
}
