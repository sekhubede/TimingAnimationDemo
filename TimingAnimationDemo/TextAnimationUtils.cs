using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace TimingAnimationDemo
{
    internal class TextAnimationUtils
    {
        public static void Blink(string text, int blinkCount = 5, int onTime = 500, int offTime = 200)
        {
            CursorVisible = false;

            for (int i = 0; i < blinkCount; i++)
            {
                WriteLine(text);
                Thread.Sleep(onTime);
                Clear();
                Thread.Sleep(offTime);
            }
            WriteLine(text);
            CursorVisible = true;
        }

        public static void AnimateTyping(string text, int delay = 25)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Write(text[i]);
                Thread.Sleep(delay);

                // Skip the animation if a key is pressed.
                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }
    }
}
