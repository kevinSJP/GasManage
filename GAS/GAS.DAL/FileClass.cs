using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GAS.DAL
{
    public class FileClass
    {
        /// <summary>
        /// 二维数组保存到txt
        /// </summary>
        /// <param name="w">二维数组</param>
        /// <param name="filename">文件名</param>
        public void saveMatrix(float[,] w, string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    sw.Write(w[i, j] + "    ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        /// <summary>
        /// 读取txt到二维数组
        /// </summary>
        /// <param name="m">数据行数</param>
        /// <param name="m">数据列数</param>
        /// <param name="filename">文件名</param>
        /// <returns>二维数组</returns>
        public float[,] readMatrix(int m, int n, string filename)
        {

            float[,] v = new float[m, n];

            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string[] line;
            for (int i = 0; i < m; i++)
            {
                line = sr.ReadLine().Split('\t');
                for (int j = 0; j < n; j++)
                {
                    //double a;                 
                    //a= Convert.ToDouble(line[j]);
                    //v[i, j] =(float)a;
                    v[i, j] = float.Parse(line[j]);
                }
            }
            sr.Close();
            fs.Close();
            return v;



        }

    }
}
