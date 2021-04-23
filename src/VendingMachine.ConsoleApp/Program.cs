using System;

namespace VendingMachine.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var vendingMachine = new VendingMachineFood();

            do
            {
                Run(vendingMachine);
            } while (!vendingMachine.Done);
        }

        public static void Run(VendingMachineFood vendingMachine)
        {
            Console.WriteLine($"\n######################################");
            Console.WriteLine($"         Vending Machine Food");
            Console.WriteLine($"######################################");
            Console.WriteLine($"Info saldo : {vendingMachine.Saldo} \n");
            Console.WriteLine("Silakan Pilih Makanan (1-6) : ");
            Console.WriteLine($"1. Tambah Saldo");
            Console.WriteLine($"2. Biskuit Harga {vendingMachine.PriceBiskuit} Stock {vendingMachine.StockBiskuit}");
            Console.WriteLine($"3. Chips Harga {vendingMachine.PriceChips} Stock {vendingMachine.StockChips}");
            Console.WriteLine($"4. Oreo Harga {vendingMachine.PriceOreo} Stock {vendingMachine.StockOreo}");
            Console.WriteLine($"5. Tango Harga {vendingMachine.PriceTango} Stock {vendingMachine.StockTango}");
            Console.WriteLine($"6. Cokelat Harga {vendingMachine.PriceCokelat} Stock {vendingMachine.StockCokelat}");
            Console.WriteLine($"7. Ambil Kembalian dan selesai");

            var selectedMenu = SelectedMenu();
            vendingMachine.SelectedMenu(selectedMenu);
        }

        public static int SelectedMenu()
        {
            int selectedMenu = 0;

            try
            {
                Console.Write("Menu yang dipilih (dalam angka 1 - 6) : ");
                selectedMenu = int.Parse(Console.ReadLine());

                return selectedMenu;
            }
            catch (Exception)
            {
                return selectedMenu;
            }
        }
    }
}
