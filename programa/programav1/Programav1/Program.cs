using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programav1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIÓN DE VARIABLES//
            int opclogin, opcmenu, opclaptop, opcgamer, opcescritorio, opcingenieria, opcaccesorios, opcregistro;
            int opcgamermedia,opcgameralta,opclaptopnueva, opcescnueva, opcescrefur, opcingdisg;
            string usuario, contraseña;
            string nombre, apellido, correo;
            string opcregistrofinal;

            int opc = 0;
            int compra=0;

            //MENÚ DE LOGIN//

            C:
                do
                {
                    Console.Clear();

                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine("1. Iniciar Sesión Cliente VIP.");
                    Console.SetCursorPosition(3, 3);
                    Console.WriteLine("2. Iniciar Sesión como Cliente Estándar.");
                   
                    Console.WriteLine("(0) Resgístrese");
                    Console.SetCursorPosition(1, 25);
                    Console.WriteLine("(3) Salir.");
                    Console.SetCursorPosition(16, 6);
                    Console.WriteLine("Indique Opción: ");
                    try
                    {
                        Console.SetCursorPosition(35, 11);
                        Console.WriteLine("                       ");
                        Console.SetCursorPosition(32, 6);
                        opclogin = int.Parse(Console.ReadLine());
                    }

                    catch
                    {

                        Console.SetCursorPosition(35, 11);
                        Console.WriteLine("Opción no válida");
                        Thread.Sleep(1000); goto C;
                    }

                    if (opclogin != 1 && opclogin != 2 && opclogin != 0)
                    {
                        Console.SetCursorPosition(35, 11);
                        Console.WriteLine("Opción no váalida");
                        Console.WriteLine("");
                        Thread.Sleep(1200);
                        Console.Clear();
                    }


                }
                while (opclogin != 1 && opclogin != 2 && opclogin != 0);
                Console.Clear();
                if (opclogin == 1)
                {
                    do
                    {
                        Console.SetCursorPosition(90, 25);
                        Console.Write("Retroceder (0)");
                        Console.SetCursorPosition(35, 10);
                        Console.Write("Nombre de Usuario: ");
                        usuario = Console.ReadLine();
                        if (usuario == "0")
                        {
                            goto C;
                        }

                        Console.SetCursorPosition(35, 11);
                        Console.Write("Contraseña: ");
                        contraseña = Console.ReadLine();

                        if (contraseña != "1234")
                        {
                            Console.SetCursorPosition(45, 14);
                            Console.WriteLine("Contraseña Incorrecta!!!");
                            Console.WriteLine("");
                            Thread.Sleep(1200);
                            Console.Clear();
                        }
                        Console.Clear();
                    }
                    while (contraseña != "1234");
                }
                if (opclogin == 0)
                {
                    Console.SetCursorPosition(90, 25);
                    Console.Write("Retroceder (0)");
                    Console.SetCursorPosition(40, 1);
                    Console.WriteLine("REGISTRO ");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(3, 2);
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    if (nombre == "0")
                    {
                        goto C;
                    }
                    Console.SetCursorPosition(3, 3);
                    Console.Write("Apellidos: ");
                    apellido = Console.ReadLine();
                    Console.SetCursorPosition(3, 4);
                    Console.Write("Correo Electrónico: ");
                    correo = Console.ReadLine();

                    do
                    {

                        Console.SetCursorPosition(90, 24);
                        Console.WriteLine("(1) Registrar ");
                        Console.SetCursorPosition(90, 25);
                        Console.WriteLine("(0) Cancelar");
                        Console.SetCursorPosition(90, 27);
                        Console.WriteLine("Indique Opción: ");

                    Z:
                        try
                        {
                            Console.SetCursorPosition(106, 27);
                            Console.WriteLine("             ");
                            Console.SetCursorPosition(106, 27);
                            opcregistro = int.Parse(Console.ReadLine());
                        }

                        catch
                        {

                            Console.SetCursorPosition(45, 27);
                            Console.WriteLine("Entrada no válida");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(45, 27);
                            Console.WriteLine("                   "); goto Z;
                        }

                        if (opcregistro != 1 && opcregistro != 0)
                        {
                            Console.SetCursorPosition(45, 27);
                            Console.WriteLine("Opción no válida");
                            Thread.Sleep(800);
                            Console.SetCursorPosition(40, 27);
                            Console.WriteLine("                         ");
                        }

                    } while (opcregistro != 0 && opcregistro != 1);


                    if (opcregistro == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(40, 2);
                        Console.WriteLine("REGISTRO ");
                        Console.SetCursorPosition(35, 5);
                        Console.WriteLine("REGISTRO ÉXITOSO!!! ");
                        Thread.Sleep(500);
                        Console.SetCursorPosition(40, 7);
                        Console.WriteLine("Usuario : " + nombre + "-OPCX");
                        Console.SetCursorPosition(40, 8);
                        Console.WriteLine("Contraseña: 1234 ");
                        Console.SetCursorPosition(30, 12);
                        Console.WriteLine("Recuerde este usuario y contraseña para iniciar Sesión");
                        Console.SetCursorPosition(30, 16);
                        Console.WriteLine("Pulse ENTER para ir al Login");
                        opcregistrofinal = Console.ReadLine();

                        goto C;
                    }

                    if (opcregistro == 0)
                    {
                        goto C;
                    }

                }
                else
                {
                    goto A;
                }















            A:
                //MENÚ DE CATEGORIA PC//
                Console.Clear();
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("1. LAPTOS.");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("2. GAMER.");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("3. COMPUTADORAS DE ESCRITORIO.");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("4. INGENIERÍA - DISEÑO GRÁFICO.");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("5. ACCESORIOS.");
                Console.SetCursorPosition(90, 25);
                Console.WriteLine("0. RETROCEDER");
                Console.SetCursorPosition(16, 9);
                Console.WriteLine("Indique Opción: ");

            G:
                do
                {

                    try
                    {
                        Console.SetCursorPosition(32, 9);
                        Console.WriteLine("                   ");
                        Console.SetCursorPosition(32, 9);
                        opcmenu = int.Parse(Console.ReadLine());
                    }

                    catch
                    {
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("Entrada no válida");
                        Thread.Sleep(1000);
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("                   "); goto G;
                    }

                    if (opcmenu == 0)
                    {
                        goto C;
                    }

                    if (opcmenu != 1 && opcmenu != 2 && opcmenu != 3 && opcmenu != 4 && opcmenu != 5 && opcmenu != 0)
                    {
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("Opción no válida");
                        Thread.Sleep(800);
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("                    ");
                    }

                }
                while (opcmenu != 1 && opcmenu != 2 && opcmenu != 3 && opcmenu != 4 && opcmenu != 5 && opcmenu != 0);

                Console.Clear();
                switch (opcmenu)
                {
                    //INICIO OPC LAPTOP//
                    case 1:
                    laptoptipo:

                        Console.Clear();
                        Console.SetCursorPosition(90, 25);
                        Console.WriteLine("0. RETROCEDER");
                        Console.SetCursorPosition(3, 2);
                        Console.WriteLine("1. NUEVAS.");
                        Console.SetCursorPosition(3, 3);
                        Console.WriteLine("2. REFURBISHED.");
                        Console.SetCursorPosition(16, 6);
                        Console.WriteLine("Indique Opción: ");

                    GR:
                        do
                        {
                            try
                            {
                                Console.SetCursorPosition(32, 6);
                                Console.WriteLine("                     ");
                                Console.SetCursorPosition(32, 6);
                                opclaptop = int.Parse(Console.ReadLine());
                            }

                            catch
                            {
                                Console.SetCursorPosition(40, 10);
                                Console.WriteLine("Entrada no válida");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(40, 10);
                                Console.WriteLine("                   "); goto GR;
                            }

                            if (opclaptop != 1 && opclaptop != 2 && opclaptop != 0)
                            {
                                Console.SetCursorPosition(40, 10);
                                Console.WriteLine("Opción no válida");
                                Thread.Sleep(800);
                                Console.SetCursorPosition(40, 10);
                                Console.WriteLine("                    ");
                            }
                        }

                        while (opclaptop != 1 && opclaptop != 2 && opclaptop != 0);

                        if (opclaptop == 0)
                        { goto A; }

                        switch (opclaptop)
                        {
                            case 1:
                            ccase3:
                                Console.Clear();
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. ACER NITRO AN515           (S/ 3,999)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. ACER PREDATOR              (S/5,999)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. ASUS GL503 V 7th           (S/3,999)");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. ASUS 504G                  (S/4,299)");
                                Console.SetCursorPosition(16, 9);
                                Console.WriteLine("Indique Opción: ");

                            GS:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 9);
                                        Console.WriteLine("                     ");
                                        Console.SetCursorPosition(32, 9);
                                        opclaptopnueva = int.Parse(Console.ReadLine());
                                    }

                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto GS;
                                    }
                                    if (opclaptopnueva != 1 && opclaptopnueva != 2 && opclaptopnueva != 3 && opclaptopnueva != 4 && opclaptopnueva != 0)
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                    ");
                                    }
                                    Console.Clear();
                                }

                                while (opclaptopnueva != 1 && opclaptopnueva != 2 && opclaptopnueva != 3 && opclaptopnueva != 4 && opclaptopnueva != 0);
                                if (opclaptopnueva == 0)
                                { goto laptoptipo; }

                                switch (opclaptopnueva)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase3; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase3; }

                                        break;

                                    case 2:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase3; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase3; }

                                        break;
                                    case 3:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase3; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase3; }

                                        break;
                                    case 4:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase3; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase3; }

                                        break;

                                }


                                break;

                            case 2:
                            ccase4:
                                Console.Clear();
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. DELL E6430                     (S/ 8,99)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. HP PROBOOK 640G1-1             (S/999)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. HP PROBOOK 640G1-2             (S/1,399)");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. LENOVO TIHINPAD - L540-1       (S/1,399)");
                                Console.SetCursorPosition(3, 6);
                                Console.WriteLine("5. LENOVO TIHINPAD – L540-2       (S/1,499)");
                                Console.SetCursorPosition(16, 9);
                                Console.WriteLine("Indique Opción: ");
                            GP:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 9);
                                        opclaptopnueva = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto GP;
                                    }
                                    if (opclaptopnueva != 1 && opclaptopnueva != 2 && opclaptopnueva != 3 && opclaptopnueva != 4 && opclaptopnueva != 5 && opclaptopnueva != 0)
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                    ");
                                    }
                                    Console.Clear();
                                }

                                while (opclaptopnueva != 1 && opclaptopnueva != 2 && opclaptopnueva != 3 && opclaptopnueva != 4 && opclaptopnueva != 5 && opclaptopnueva != 0);

                                if (opclaptopnueva == 0)
                                { goto laptoptipo; }

                                switch (opclaptopnueva)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase4; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase4; }

                                        break;

                                    case 2:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase4; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase4; }

                                        break;
                                    case 3:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase4; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase4; }

                                        break;

                                    case 4:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase4; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase4; }

                                        break;

                                    case 5:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase4; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase4; }

                                        break;
                                }
                                break;
                        }


                        break;
                    //FIN OPC LAPTOP//


                    //INICIO OPC GAMER//
                    case 2:
                    gamasgamer:
                        Console.SetCursorPosition(90, 25);
                        Console.WriteLine("0. RETROCEDER");
                        Console.SetCursorPosition(3, 2);
                        Console.WriteLine("1. GAMA MEDIA.");
                        Console.SetCursorPosition(3, 3);
                        Console.WriteLine("2. GAMA ALTA.");
                        Console.SetCursorPosition(16, 6);
                        Console.WriteLine("Indique Opción: ");

                    GA:
                        do
                        {
                            try
                            {
                                Console.SetCursorPosition(32, 6);
                                Console.WriteLine("                          ");
                                Console.SetCursorPosition(32, 6);
                                opcgamer = int.Parse(Console.ReadLine());
                            }

                            catch
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("Entrada no válida");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("                   "); goto GA;
                            }

                            if (opcgamer != 1 && opcgamer != 2 && opcgamer != 0)
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("Opción no válida");
                                Thread.Sleep(800);
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("                    ");
                            }
                        }

                        while (opcgamer != 1 && opcgamer != 2 && opcgamer != 0);
                        if (opcgamer == 0)
                        { goto A; }

                        switch (opcgamer)
                        {
                            case 1:
                            ccase1:
                                Console.Clear();
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. HP 6000 - 1                  (S/1,099)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. HP 6000 - 2                  (S/1,299)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. GAMER MIRAGE                 (S/1,499)");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. PC GAMER CCA3237-BR - 1      (S/1,599)");
                                Console.SetCursorPosition(3, 6);
                                Console.WriteLine("5. PC GAMER CCA3237-BR - 2      (S/1,599)");
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("6. PC GAMER CCA3237-BR - 3      (S/1,999)");
                                Console.SetCursorPosition(3, 8);
                                Console.WriteLine("7. PC GAMER SPIDER - 1          (S/2,299)");
                                Console.SetCursorPosition(3, 9);
                                Console.WriteLine("8. PC GAMER SPIDER - 2          (S/2,499)");
                                Console.SetCursorPosition(3, 10);
                                Console.WriteLine("9. PC GAMER SPIDER - 3          (S/2,699)");
                                Console.SetCursorPosition(3, 11);
                                Console.WriteLine("10. PC GAMER SPIDER - 4         (S/2,999)");
                                Console.SetCursorPosition(16, 14);
                                Console.WriteLine("Indique Opción: ");

                            BR:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 14);
                                        Console.WriteLine("                         ");
                                        Console.SetCursorPosition(32, 14);
                                        opcgamermedia = int.Parse(Console.ReadLine());
                                    }

                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto BR;
                                    }

                                    if (opcgamermedia != 1 && opcgamermedia != 2 && opcgamermedia != 3 && opcgamermedia != 4 && opcgamermedia != 5 && opcgamermedia != 6 && opcgamermedia != 7 && opcgamermedia != 8 && opcgamermedia != 9 && opcgamermedia != 10 && opcgamermedia != 0)
                                    {
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("                    ");

                                    }
                                    Console.Clear();
                                }

                                while (opcgamermedia != 1 && opcgamermedia != 2 && opcgamermedia != 3 && opcgamermedia != 4 && opcgamermedia != 5 && opcgamermedia != 6 && opcgamermedia != 7 && opcgamermedia != 8 && opcgamermedia != 9 && opcgamermedia != 10 && opcgamermedia != 0);

                                if (opcgamermedia == 0)
                                { goto gamasgamer; }

                                switch (opcgamermedia)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1985; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }

                                        break;

                                    case 2:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1200; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }

                                        break;

                                    case 3:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1500; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }

                                        break;

                                    case 4:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }

                                        break;

                                    case 5:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 2000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }

                                        break;

                                    case 6:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }
                                        break;

                                    case 7:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }
                                        break;

                                    case 8:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }
                                        break;

                                    case 9:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }
                                        break;

                                    case 10:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1000; goto ccase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto ccase1; }
                                        break;
                                }
                                break;

                            case 2:
                            ccase2:
                                Console.Clear();
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. SPIDER CORE I3 8100 8Th Gen         (S/3,199)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. SPIDER CORE I5 8400 8Th Gen         (S/3,699)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. SPIDER CORE I5 8400 8Th Gen         (S/4,299)");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. PC SPIDER CORE I7 8700 8Th Gen      (S/4,999)");
                                Console.SetCursorPosition(3, 6);
                                Console.WriteLine("5. PC SPIDER CORE I7 8700 8Th Gen      (S/5,999)");
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(16, 14);
                                Console.WriteLine("Indique Opción: ");

                            BA:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 14);
                                        Console.WriteLine("                         ");
                                        Console.SetCursorPosition(32, 14);
                                        opcgameralta = int.Parse(Console.ReadLine());
                                    }

                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto BA;
                                    }

                                    if (opcgameralta != 1 && opcgameralta != 2 && opcgameralta != 3 && opcgameralta != 4 && opcgameralta != 5 && opcgameralta != 0)
                                    {
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("                    ");
                                    }


                                    Console.Clear();
                                }

                                while (opcgameralta != 1 && opcgameralta != 2 && opcgameralta != 3 && opcgameralta != 4 && opcgameralta != 5 && opcgameralta != 0);


                                if (opcgameralta == 0)
                                { goto gamasgamer; }

                                switch (opcgameralta)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1985; goto ccase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto ccase2;
                                        }

                                        break;

                                    case 2:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1200; goto ccase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto ccase2;
                                        }

                                        break;

                                    case 3:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1500; goto ccase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto ccase2;
                                        }

                                        break;

                                    case 4:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1000; goto ccase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto ccase2;
                                        }

                                        break;

                                    case 5:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 2000; goto ccase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto ccase2;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    //FIN OPCION GAMER//


                    //INICIO OPCION COMPUTADORAS ESCRITORIO
                    case 3:
                    compesc:
                        Console.SetCursorPosition(90, 25);
                        Console.WriteLine("0. RETROCEDER");
                        Console.SetCursorPosition(3, 2);
                        Console.WriteLine("1. NUEVAS.");
                        Console.SetCursorPosition(3, 3);
                        Console.WriteLine("2. REFURBISHED.");
                        Console.SetCursorPosition(16, 6);
                        Console.WriteLine("Indique Opción: ");
                    CE:
                        do
                        {
                            try
                            {
                                Console.SetCursorPosition(32, 6);
                                Console.WriteLine("                          ");
                                Console.SetCursorPosition(32, 6);
                                opcescritorio = int.Parse(Console.ReadLine());
                            }

                            catch
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("Entrada no válida");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("                   "); goto CE;
                            }

                            if (opcescritorio != 1 && opcescritorio != 2 && opcescritorio != 0)
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("Opción no válida");
                                Thread.Sleep(800);
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("                    ");
                            }
                        }

                        while (opcescritorio != 1 && opcescritorio != 2 && opcescritorio != 0);
                        if (opcescritorio == 0)
                        { goto A; } //MENÚ CATEGORÍA

                        switch (opcescritorio)
                        {
                            case 1:
                            caase1:
                                Console.Clear();
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. MIRAGE CORE I3 8100 8Th Gen  (S/1,799)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. MIRAGE CORE I5 8400 8Th Gen (S/2,199)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. MIRAGE CORE I5 8400 8Th Gen (S/2,599)");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. MIRAGE CORE I7 8700 8Th Gen (S/3,199)");
                                Console.SetCursorPosition(3, 6);
                                Console.WriteLine("5. MIRAGE CORE I7 8700 8Th Gen (S/3,199)");
                                Console.SetCursorPosition(16, 14);
                                Console.WriteLine("Indique Opción: ");

                            RB:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 14);
                                        Console.WriteLine("                         ");
                                        Console.SetCursorPosition(32, 14);
                                        opcescnueva = int.Parse(Console.ReadLine());
                                    }

                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto RB;
                                    }

                                    if (opcescnueva != 1 && opcescnueva != 2 && opcescnueva != 3 && opcescnueva != 4 && opcescnueva != 5 && opcescnueva != 0)
                                    {
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("                    ");

                                    }
                                    Console.Clear();
                                }

                                while (opcescnueva != 1 && opcescnueva != 2 && opcescnueva != 3 && opcescnueva != 4 && opcescnueva != 5 && opcescnueva != 0);

                                if (opcescnueva == 0)
                                { goto compesc; }

                                switch (opcescnueva)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1799; goto caase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto caase1; }

                                        break;

                                    case 2:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 2199; goto caase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto caase1; }

                                        break;

                                    case 3:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 2599; goto caase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto caase1; }

                                        break;

                                    case 4:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 3199; goto caase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto caase1; }

                                        break;

                                    case 5:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        { compra = compra + 1199; goto caase1; }
                                        if (opc == 2)
                                        { goto AAA; }
                                        if (opc == 3)
                                        { goto caase1; }

                                        break;
                                }
                                break;

                            case 2:
                            caase2:
                                Console.Clear();
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. HP 6005 PRO – 1      (S/289)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. HP 6005 PRO – 2      (S/399)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. HP 6005 PRO – 3      (S/549) ");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. HP 6200 PRO - 1      (S/699)");
                                Console.SetCursorPosition(3, 6);
                                Console.WriteLine("5. HP 6305 PRO          (S/799)");
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("6. HP 6200 PRO - 2      (S/999)");
                                Console.SetCursorPosition(3, 8);
                                Console.WriteLine("7. HP 6200 PRO - 3      (S/1,299)");
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(16, 14);
                                Console.WriteLine("Indique Opción: ");

                            ER:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 14);
                                        Console.WriteLine("                         ");
                                        Console.SetCursorPosition(32, 14);
                                        opcescrefur = int.Parse(Console.ReadLine());
                                    }

                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto ER;
                                    }

                                    if (opcescrefur != 1 && opcescrefur != 2 && opcescrefur != 3 && opcescrefur != 4 && opcescrefur != 5 && opcescrefur != 6 && opcescrefur != 6 && opcescrefur != 0)
                                    {
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("                    ");
                                    }


                                    Console.Clear();
                                }

                                while (opcescrefur != 1 && opcescrefur != 2 && opcescrefur != 3 && opcescrefur != 4 && opcescrefur != 5 && opcescrefur != 6 && opcescrefur != 6 && opcescrefur != 0);


                                if (opcescrefur == 0)
                                { goto compesc; }

                                switch (opcescrefur)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 289; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }

                                        break;

                                    case 2:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 399; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }

                                        break;

                                    case 3:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 549; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }

                                        break;

                                    case 4:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 699; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }

                                        break;

                                    case 5:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 799; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }
                                        break;
                                    case 6:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 999; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }
                                        break;
                                    case 7:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1299; goto caase2;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase2;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    //FIN OPCION COMPUTADORAS DE ESCRITORIO//


                    //INICIO OPCION COMPUTADORAS INGENIERIA - DISEÑO GRAFICO//
                    case 4:
                    ingdis:
                        Console.SetCursorPosition(90, 25);
                        Console.WriteLine("0. RETROCEDER");
                        Console.SetCursorPosition(3, 2);
                        Console.WriteLine("1. Ingeniería y Diseño Gráfico.");
                        Console.SetCursorPosition(16, 6);
                        Console.WriteLine("Indique Opción: ");
                    ID:
                        do
                        {
                            try
                            {
                                Console.SetCursorPosition(32, 6);
                                Console.WriteLine("                          ");
                                Console.SetCursorPosition(32, 6);
                                opcingenieria = int.Parse(Console.ReadLine());
                            }

                            catch
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("Entrada no válida");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("                   "); goto ID;
                            }

                            if (opcingenieria != 1 && opcingenieria != 0)
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("Opción no válida");
                                Thread.Sleep(800);
                                Console.SetCursorPosition(40, 12);
                                Console.WriteLine("                    ");
                            }
                        }

                        while (opcingenieria != 1 && opcingenieria != 2 && opcingenieria != 0);
                        if (opcingenieria == 0)
                        {
                            goto A;
                        } //MENÚ CATEGORÍA

                        switch (opcingenieria)
                        {
                            case 1:
                            caase1:
                                Console.Clear();
                                Console.SetCursorPosition(90, 25);
                                Console.WriteLine("0. RETROCEDER");
                                Console.SetCursorPosition(3, 2);
                                Console.WriteLine("1. HP 6200 – 1                 (S/1,299)");
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("2. HP 6200 - 2                 (S/1,499)");
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("3. HP 6200 – 3                 (S/1,699)");
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("4. HP 6200 – 1                 (S/1,899)");
                                Console.SetCursorPosition(3, 6);
                                Console.WriteLine("5. HP 6200 – 1                 (S/2,499)");
                                Console.SetCursorPosition(16, 14);
                                Console.WriteLine("Indique Opción: ");

                            RB:
                                do
                                {
                                    try
                                    {
                                        Console.SetCursorPosition(32, 14);
                                        Console.WriteLine("                         ");
                                        Console.SetCursorPosition(32, 14);
                                        opcingdisg = int.Parse(Console.ReadLine());
                                    }

                                    catch
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("Entrada no válida");
                                        Thread.Sleep(1000);
                                        Console.SetCursorPosition(40, 12);
                                        Console.WriteLine("                   "); goto RB;
                                    }

                                    if (opcingdisg != 1 && opcingdisg != 2 && opcingdisg != 3 && opcingdisg != 4 && opcingdisg != 5 && opcingdisg != 0)
                                    {
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("Opción no válida");
                                        Thread.Sleep(800);
                                        Console.SetCursorPosition(40, 18);
                                        Console.WriteLine("                    ");

                                    }
                                    Console.Clear();
                                }

                                while (opcingdisg != 1 && opcingdisg != 2 && opcingdisg != 3 && opcingdisg != 4 && opcingdisg != 5 && opcingdisg != 0);

                                if (opcingdisg == 0)
                                {
                                    goto ingdis;
                                }

                                switch (opcingdisg)
                                {
                                    case 1:

                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1299; goto caase1;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase1;
                                        }

                                        break;

                                    case 2:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1499; goto caase1;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase1;
                                        }

                                        break;

                                    case 3:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1699; goto caase1;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase1;
                                        }

                                        break;

                                    case 4:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 1899; goto caase1;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase1;
                                        }

                                        break;

                                    case 5:
                                        Console.WriteLine("(1) Añadir al Carrito.");
                                        Console.WriteLine("(2) Realizar Pago.");
                                        Console.WriteLine("(3) Retroceder.");
                                        opc = int.Parse(Console.ReadLine());
                                        if (opc == 1)
                                        {
                                            compra = compra + 2499; goto caase1;
                                        }
                                        if (opc == 2)
                                        {
                                            goto AAA;
                                        }
                                        if (opc == 3)
                                        {
                                            goto caase1;
                                        }

                                        break;
                                }
                                break;
                        }
                        break;
                    //FIN OPCION INGENIERIA - DISEÑO GRAFICO//

                    case 5:

                        break;
                        //FIN OPCION ACCESORIOS//
                }
            //FIN DEL SWITCH DEL MENÚ

            AAA:
                Console.Clear();
                Console.WriteLine("PRECIO TOTAL: " + compra);
                Console.ReadKey();
            
        }
    }
}
