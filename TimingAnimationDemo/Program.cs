﻿using System;
using static System.Console;

namespace TimingAnimationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Animation Demo";

            
//            TextAnimationUtils.Blink(@"
//                                              .-'''-.     
//                                .---..---.   '   _    \   
//   .              __.....__     |   ||   | /   /` '.   \  
// .'|          .-''         '.   |   ||   |.   |     \  '  
//<  |         /     .-''""'-.  `. |   ||   ||   '      |  ' 
// | |        /     /________\   \|   ||   |\    \     / /  
// | | .'''-. |                  ||   ||   | `.   ` ..' /   
// | |/.'''. \\    .-------------'|   ||   |    '-...-'`    
// |  /    | | \    '-.____...---.|   ||   |                
// | |     | |  `.             .' |   ||   |                
// | |     | |    `''-...... -'   '---''---'                
// | '.    | '.                                             
// '---'   '---'                                            
//", 10, 1000, 50);

            string programmingQuote = @"Words of wisdom:
Sometimes it's better to leave something alone, to pause,
and that's very true of programming.
- Joyce Wheeler";
            TextAnimationUtils.AnimateTyping(programmingQuote, 50);
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
