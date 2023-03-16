using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        
    }
}
