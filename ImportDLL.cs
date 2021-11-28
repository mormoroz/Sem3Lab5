using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Sem3Lab5
{
    public static class ImportDLL
    {
        private const string FileNameDLL = @"V:\Sem3lab5\Debug\MatrixDLL.dll";
        [DllImport(FileNameDLL, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I8)]
        private extern static Int64 CreateAndRepeatSolveC([param: MarshalAs(UnmanagedType.I4)] int n, [param: MarshalAs(UnmanagedType.I4)] int r);
        [DllImport(FileNameDLL, CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr CreateAndSolveC([param: MarshalAs(UnmanagedType.I4)] int s, double[] r, double[] right);
        public static long CreateAndRepeate(int n, int r)
        {
            return CreateAndRepeatSolveC(n, r);
        }
        public static double[] CreateAndSolve(Matrix a, double[] right)
        {
            double[] result = new double[a.size];
            Marshal.Copy(CreateAndSolveC(a.size, a.row, right), result, 0, a.size);
            return result;
        }
    }
}