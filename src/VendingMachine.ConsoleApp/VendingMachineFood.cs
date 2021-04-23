using System;

namespace VendingMachine.ConsoleApp
{
    public class VendingMachineFood
    {
        public bool Done { get; set; }

        public decimal PriceBiskuit { get; set; }
        public decimal StockBiskuit { get; set; }

        public decimal PriceChips { get; set; }
        public decimal StockChips { get; set; }

        public decimal PriceOreo { get; set; }
        public decimal StockOreo { get; set; }

        public decimal PriceTango { get; set; }
        public decimal StockTango { get; set; }

        public decimal PriceCokelat { get; set; }
        public decimal StockCokelat { get; set; }

        public decimal Saldo { get; set; }

        public VendingMachineFood()
        {
            PriceBiskuit = 6000;
            StockBiskuit = 5;

            PriceChips = 8000;
            StockChips = 3;

            PriceOreo = 10000;
            StockOreo = 4;

            PriceTango = 12000;
            StockTango = 6;

            PriceCokelat = 15000;
            StockCokelat = 10;
        }

        public void InputSaldo()
        {
            Console.Write("Masukan Jumlah Saldo : ");
            bool successAddSaldo = decimal.TryParse(Console.ReadLine(), out decimal nominalAddSaldo);

            if (successAddSaldo)
            {
                switch (nominalAddSaldo)
                {
                    case 2000:
                    case 5000:
                    case 10000:
                    case 20000:
                    case 50000:
                        Console.Clear();

                        Console.WriteLine($"saldo yang dimasukan : {nominalAddSaldo}");

                        Saldo += nominalAddSaldo;

                        Console.WriteLine($"saldo anda sekarang : {Saldo} \n");
                        break;

                    default:
                        Console.Clear();

                        Console.WriteLine("\nNominal yang dapat dimasukan hanya 2000, 5000, 10000, 20000, 50000\n");
                        break;
                }
            }
            else
            {
                Console.Clear();

                Console.WriteLine("\ncek kembali inputan yang diberikan!\n");
            }
        }

        public void GetSaldo()
        {
            Console.WriteLine($"Sisa Saldo Anda : {Saldo}\n");
        }

        public void Refund()
        {
            Console.Clear();

            Console.WriteLine($"Anda berhasil menarik sisa saldo anda sebesar {Saldo}");
            Saldo = 0;

            Environment.Exit(0);
        }

        public void SelectedMenu(int selectedMenu)
        {
            switch (selectedMenu)
            {
                case 0:
                    Console.WriteLine("cek kembali menu yang dipilih!");
                    Console.WriteLine("memilih menu hanya menggunakan angka 1-6 !");
                    break;
                case 1:
                    InputSaldo();
                    break;
                case 2:
                    BuyBiskuit();
                    break;
                case 3:
                    BuyChips();
                    break;
                case 4:
                    BuyOreo();
                    break;
                case 5:
                    BuyTango();
                    break;
                case 6:
                    BuyCokelat();
                    break;
                case 7:
                    Refund();
                    break;

                default:
                    Console.WriteLine("tidak ada pada Menu pilihan!");
                    break;
            }
        }

        public void BuyBiskuit()
        {
            if (StockBiskuit != 0)
            {
                if (Saldo < PriceBiskuit)
                {
                    SaldoMinus("Biskuit", PriceBiskuit);
                }
                else
                {
                    Console.Clear();

                    Saldo -= PriceBiskuit;
                    StockBiskuit--;
                    Console.WriteLine($"\nAnda membeli Biskuit dengan harga ({PriceBiskuit})");
                    GetSaldo();
                }
            }
            else
            {
                SoldOut("Biskuit");
            }
        }

        public void BuyChips()
        {
            if (StockChips != 0)
            {
                if (Saldo < PriceChips)
                {
                    SaldoMinus("Chips", PriceChips);
                }
                else
                {
                    Console.Clear();

                    Saldo -= PriceChips;
                    StockChips--;
                    Console.WriteLine($"\nAnda membeli Chips dengan harga ({PriceChips})");
                    GetSaldo();
                }
            }
            else
            {
                SoldOut("Chips");
            }
        }

        public void BuyOreo()
        {
            if (StockOreo != 0)
            {
                if (Saldo < PriceOreo)
                {
                    SaldoMinus("Oreo", PriceOreo);
                }
                else
                {
                    Console.Clear();

                    Saldo -= PriceOreo;
                    StockOreo--;
                    Console.WriteLine($"\nAnda membeli Oreo dengan harga ({PriceOreo})");
                    GetSaldo();
                }
            }
            else
            {
                SoldOut("Oreo");
            }
        }

        public void BuyTango()
        {
            if (StockTango != 0)
            {
                if (Saldo < PriceTango)
                {
                    SaldoMinus("Tango", PriceTango);
                }
                else
                {
                    Console.Clear();

                    Saldo -= PriceTango;
                    StockTango--;
                    Console.WriteLine($"\nAnda membeli Tango dengan harga ({PriceTango})");
                    GetSaldo();
                }
            }
            else
            {
                SoldOut("Tango");
            }
        }

        public void BuyCokelat()
        {
            if (StockCokelat != 0)
            {
                if (Saldo < PriceCokelat)
                {
                    SaldoMinus("Cokelat", PriceCokelat);
                }
                else
                {
                    Console.Clear();

                    Saldo -= PriceCokelat;
                    StockCokelat--;
                    Console.WriteLine($"\nAnda membeli Cokelat dengan harga ({PriceCokelat})");
                    GetSaldo();
                }
            }
            else
            {
                SoldOut("Cokelat");
            }
        }

        public void SaldoMinus(string food, decimal price)
        {
            Console.Clear();

            Console.WriteLine($"\nSaldo anda sekarang {Saldo}");
            Console.WriteLine($"tidak dapat membeli {food} dengan harga {price}\n");
        }

        public void SoldOut(string food)
        {
            Console.Clear();

            Console.WriteLine($"\n{food} habis!\n");
        }
    }
}