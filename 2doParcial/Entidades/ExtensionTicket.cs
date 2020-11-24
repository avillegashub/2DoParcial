using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{


    public static class ExtensionTicket
    {
        /// <summary>
        /// Adjunta una la venta en Archivo .txt
        /// </summary>
        /// <param name="venta"></param>
        public static void PrintTicket(this object o)
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Tickets\\" + Comercio.ventas.Last().Id + Comercio.ventas.Last().Orden + ".txt", false))
                    sw.WriteLine(o);
            }
            catch (Exception ex)
            {

                string.Concat(DateTime.Now.ToString(), ex.Message).RegistrarError();
            }
        }
        public static void RegistrarError(this object o)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Logs\\" + "ErrorLog" + ".txt", true))
                    sw.WriteLine("~"+o);

            }
            catch (Exception ex)
            {

                string.Concat(DateTime.Now.ToString(), ex.Message).RegistrarError();
            }
        }

    }

}
