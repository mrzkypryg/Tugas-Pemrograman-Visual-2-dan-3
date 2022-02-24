/*
 * Created by SharpDevelop.
 * User: Muhammad Rizky Prayoga (201401024)
 * Date: 2/24/2022
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BelajarCSHARP
{
class programHW
	{
		static void Main (string[] args)
		{
			Console.Write("Nama kamu siapa ? \n");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu "+nama);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}