using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;

namespace HomeBrew
{
    public static class TitleScreen
    {
        // Displays Title... beer mug   Homebrew!
        public static void Title()
        {
            Console.Clear();
            AnsiConsole.Markup("[white]      ******\n[/] ");
            AnsiConsole.Markup("[gray on black]    [white]********[/]        [green]*   *                          *                                *[/]                       \n[/]  ");
            AnsiConsole.Markup("[gray on black]  [white]*[/]*[olive]****[/][white]**[/]***      [green]*   *                          *                                *[/]                       \n[/]  ");
            AnsiConsole.Markup("[gray on black]  [white]*[/]*[olive]*****[/][white]*[/]*  *     [green]*   *  * * *  *     *   * *    *       * *   * *                *[/]                       \n[/]  ");
            AnsiConsole.Markup("[gray on black]   *[olive]******[/]*  *     [green]* * *  *   *  * * * *  *    *  * *    *     *    *  *        *  *[/]                        \n[/]  ");
            AnsiConsole.Markup("[gray on black]   *[olive]******[/]*  *     [green]*   *  *   *  *  *  *  * * *   *   *  *     * * *    *      *   *[/]                       \n[/]  ");
            AnsiConsole.Markup("[gray on black]   *[olive]******[/]***      [green]*   *  *   *  *     *  *       *   *  *     *         * ** *[/]                       \n[/]  ");
            AnsiConsole.Markup("[gray on black]   ********        [green]*   *  * * *  *     *   * *    * * *  *      * *       *  *     *[/]                       \n[/]  ");
            Console.WriteLine();
            AnsiConsole.Markup("[olive]======================================================================================\n[/]");
            Console.WriteLine();
        }

        public static void LoadingAnimiation()
        {
            // animation start
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Title();
                Console.WriteLine("Loading...  |");
                Thread.Sleep(300);
                

                Console.Clear();
                Title();
                Console.WriteLine("Loading...  /");
                Thread.Sleep(300);
                

                Console.Clear();
                Title();
                Console.WriteLine("Loading...  -");
                Thread.Sleep(300);


                Console.Clear();
                Title();
                Console.WriteLine(@"Loading...  \");
                Thread.Sleep(300);
                

            }


            // animation end
        }

    }
}
