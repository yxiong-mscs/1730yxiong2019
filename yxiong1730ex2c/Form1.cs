using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex2c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetMinButton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte1 = Byte.MinValue;  byte1textBox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue;  sbyte1textBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue; short1textBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue; ushort1textBox.Text = ushort1.ToString();
            int1 = Int32.MinValue; int1textBox.Text = int1.ToString();
            uint1 = UInt32.MinValue; uint1textBox.Text = uint1.ToString();
            long1 = Int64.MinValue; long1textBox.Text = long1.ToString();
            ulong1 = UInt64.MinValue; ulong1textBox.Text = ulong1.ToString();
            float1 = Single.MinValue; float1textBox.Text = float1.ToString();
            double1 = Double.MinValue; double1textBox.Text = double1.ToString();
            decimal1 = Decimal.MinValue; decimal1textBox.Text = decimal1.ToString();
        }

        private void SetMaxButton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte2 = Byte.MaxValue; byte2textBox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2textBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2textBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2textBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2textBox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2textBox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2textBox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2textBox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2textBox.Text = float2.ToString();
            double2 = Double.MaxValue; double2textBox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; decimal2textBox.Text = decimal2.ToString();
        }
    }
}
