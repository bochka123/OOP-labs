using System;
using System.Linq;
/*
* Oleksandr Tkach
* number of the score book - 328
* C3 - 1
* C17 - 5  
*/
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Cras sagittis egestas diam eu condimentum. Sed pharetra ex eu orci aliquet laoreet." +
                " Proin ut eleifend dolor. Suspendisse nec lacus nec leo laoreet ultrices." +
                " Duis congue nunc a ante vehicula vehicula. Fusce nec tristique sapien." +
                " Phasellus ultricies neque quis ante mattis blandit." +
                " Vestibulum tempor, quam ut facilisis faucibus, est turpis sagittis nulla, a ullamcorper augue orci et nibh." +
                " Sed quis arcu at leo egestas finibus. In hac habitasse platea dictumst." +
                " Proin faucibus nunc a metus sodales eleifend. Mauris quis ante gravida, dictum sem dapibus, molestie mi." +
                " Donec sagittis tellus mauris, quis imperdiet diam dignissim eget.";
            char[] symb = { ',', '.', ' ' };
            String[] words = text.Split(symb);
            String[] nonRepeatingWords = words.Distinct().ToArray();
            Array.Sort(nonRepeatingWords);
            foreach (String word in nonRepeatingWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
