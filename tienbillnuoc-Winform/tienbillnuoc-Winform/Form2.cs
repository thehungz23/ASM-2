using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienbillnuoc_Winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                string clientName = txtClientName.Text;
                string customerType = cbxCustomerType.SelectedItem.ToString().ToLower();
                int numberOfPeople = (int)numPeople.Value;
                int lastMonthReading = int.Parse(txtLastMonthReading.Text);
                int thisMonthReading = int.Parse(txtThisMonthReading.Text);

                // Tính toán lượng nước tiêu thụ
                int waterConsumption = thisMonthReading - lastMonthReading;
                if (waterConsumption < 0)
                {
                    MessageBox.Show("This month's reading must be greater than or equal to last month's reading..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính toán tổng số tiền nước
                double totalBill = CalculateWaterBill(customerType, numberOfPeople, waterConsumption);

                // Hiển thị kết quả trong TextBox
                txtResult.Text = $"Tên khách hàng: {clientName}\n " +
                                                                     $"\n Last month's water meter reading: {lastMonthReading}\n" +
                                                                             $"\n Water meter reading this month: {thisMonthReading}\n" +
                                                                                 $"\n Water consumption: {waterConsumption} m³\n" +
                                                                                          $"\n Total water bill: {totalBill} VND (including 10% VAT)";

                // Thêm kết quả vào ListView
                ListViewItem item = new ListViewItem(clientName);
                item.SubItems.Add(customerType);
                item.SubItems.Add(lastMonthReading.ToString());
                item.SubItems.Add(thisMonthReading.ToString());
                item.SubItems.Add(waterConsumption.ToString());
                item.SubItems.Add(totalBill.ToString());
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateWaterBill(string customerType, int numberOfPeople, double waterConsumption)
        {
            double waterPrice = 0.0;
            double environmentFee = 0.0;

            switch (customerType)
            {
                case "household":
                    double consumptionPerPerson = waterConsumption / numberOfPeople;
                    if (consumptionPerPerson <= 10.0)
                    {
                        waterPrice = 597.0;
                        environmentFee = 59.7;
                    }
                    else if (consumptionPerPerson <= 20.0)
                    {
                        waterPrice = 708.0;
                        environmentFee = 70.8;
                    }
                    else if (consumptionPerPerson <= 30.0)
                    {
                        waterPrice = 869.0;
                        environmentFee = 86.9;
                    }
                    else
                    {
                        waterPrice = 1592.9;
                        environmentFee = 159.2;
                    }
                    break;

                case "administrative agency public services":
                    waterPrice = 995.5;
                    environmentFee = 99.5;
                    break;

                case "production units":
                    waterPrice = 1161.9;
                    environmentFee = 116.1;
                    break;

                case "business services":
                    waterPrice = 2206.0;
                    environmentFee = 220.6;
                    break;
            }

            return CalculateTotalBill(waterPrice, environmentFee, waterConsumption);
        }

        private double CalculateTotalBill(double waterPrice, double environmentFee, double waterConsumption)
        {
            throw new NotImplementedException();
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
         
        }

        private void txtExit_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void txtRemove_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show(" Please choose 1 line to delete", "Notice to you");
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
