using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    public static class TitleScreen
    {
        // Displays Title
        public static void Title()
        {
            Console.WriteLine("   *****                                                                                     ");
            Console.WriteLine("  *******           *   *                          *                                *        ");
            Console.WriteLine("  *      ***        *   *                          *                                *          ");
            Console.WriteLine("  *      *  *       *   *  * * *  *     *   * *    *       * *   * *                *      ");
            Console.WriteLine("  *      *  *       * * *  *   *  * * * *  *    *  * *    *     *    *  *        *  *         ");
            Console.WriteLine("  *      *  *       *   *  *   *  *  *  *  * * *   *   *  *     * * *    *      *   *        ");
            Console.WriteLine("  *      ***        *   *  *   *  *     *  *       *   *  *     *         * ** *              ");
            Console.WriteLine("  ********          *   *  * * *  *     *   * *    * * *  *      * *       *  *     *       ");

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }


        // Displays Menu
        public static void TitleMenu()
        {
            Console.WriteLine("Welcome to the Pawtucket Homebrew Tool!");
            Console.WriteLine("Would you like to start building a recipe or use a homebrew tool?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu options");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Buid a Recipe:     Press 1");
            Console.WriteLine("--------------------------");
            // Console.WriteLine("Homebrew Tools:");
            Console.WriteLine("Brix to Specfic");
            Console.WriteLine("Gravity Converter: Press 2");
            Console.WriteLine("--------------------------");
            Console.WriteLine("ABV Calculator:    Press 3");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Exit:              Press 0");
            Console.WriteLine("--------------------------");
            Console.Write("Your input: ");
        }
    }
}
