using BancoTheBanco.Clases;
using System;
using System.Collections.Generic;

namespace BancoTheBanco
{
    class Program


    {
        static void Main(string[] args)
        {

            List<cliente> listaCliente = new List<cliente>();
            List<cuenta> listaCuentas = new List<cuenta>();
            List<administrador> listaAdmin = new List<administrador>();
            Random ncu = new Random();

            int opcion = -1;
            while (opcion != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("┌────────────────────────────────────────────┐");
                Console.WriteLine("│               Banco THE BANCO              │");
                Console.WriteLine("├─────────────────────MENU───────────────────┤");
                Console.WriteLine("│1.-Registrar                                │");
                Console.WriteLine("│2.-Crear cuenta bancaria                    │");
                Console.WriteLine("│3.-Consultar saldo                          │");
                Console.WriteLine("│4.-Realizar Deposito a cuenta               │");
                Console.WriteLine("│5.-Realizar Giro de cuenta                  │");
                Console.WriteLine("│6.-Buscar cliente por rut                   │");
                Console.WriteLine("│7.-Modificar Datos                          │");
                Console.WriteLine("│0.-Salir                                    │");
                Console.WriteLine("└────────────────────────────────────────────┘");
                Console.Write("Opcion: ");
                Console.WriteLine("");

                int opciones = Convert.ToInt32(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│                  Registro                  │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine(" Ingrese el tipo de usuario que registrara:");
                        Console.WriteLine(" 1.- Cliente");
                        Console.WriteLine(" 2.- Administrador");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.Write("Opcion: ");

                        int opc = Convert.ToInt32(Console.ReadLine());

                        switch (opc)
                        {
                            case 1:
                                Console.WriteLine("┌────────────────────────────────────────────┐");
                                Console.WriteLine("│             Registro de cliente            │");
                                Console.WriteLine("└────────────────────────────────────────────┘");
                                Console.WriteLine();
                                Console.WriteLine("Ingrese el RUT del cliente (sin punto ni guion): ");
                                string rut = Console.ReadLine();
                                Console.WriteLine("Ingrese nombre del cliente: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido del cliente: ");
                                string apellido = Console.ReadLine();
                                cliente nuevocliente = new cliente(nombre, apellido, rut, "Cliente");
                                Console.WriteLine("Registro Exitoso");
                                listaCliente.Add(nuevocliente);
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    Nombre: {nuevocliente.Nombre}");
                                Console.WriteLine($"    Apellido: {nuevocliente.Apellido}");
                                Console.WriteLine($"    Rut: {nuevocliente.Rut}");
                                Console.WriteLine($"    Tipo: {nuevocliente.Tipo}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                                break;

                            case 2:
                                Console.WriteLine("┌────────────────────────────────────────────┐");
                                Console.WriteLine("│          Registro de Administrador         │");
                                Console.WriteLine("└────────────────────────────────────────────┘");
                                Console.WriteLine();
                                Console.WriteLine("Ingrese nombre del Administrador: ");
                                string nombreQ = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido del Administrador: ");
                                string apellidoQ = Console.ReadLine();
                                Console.WriteLine("Ingrese el RUT del Administrador (sin punto ni guion): ");
                                string rutQ = Console.ReadLine();
                                administrador nuevoAdmin = new administrador(nombreQ, apellidoQ, rutQ, "Administrador");
                                Console.WriteLine("Registro Exitoso");
                                listaAdmin.Add(nuevoAdmin);
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    Nombre: {nuevoAdmin.Nombre}");
                                Console.WriteLine($"    Apellido: {nuevoAdmin.Apellido}");
                                Console.WriteLine($"    Rut: {nuevoAdmin.Rut}");
                                Console.WriteLine($"    Tipo: {nuevoAdmin.Tipo}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│            Crear cuenta bancaria           │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese Rut (sin punto ni guion): ");
                        string rutA = Console.ReadLine();
                        Console.WriteLine();

                        foreach (cliente a in listaCliente)
                        {
                            if (a.Rut == rutA)
                            {
                                Console.WriteLine("ingrese contraseña de la cuenta: ");
                                int contA = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Ingrese el dinero que desea depositar en su cuenta: $");
                                int saldoA = Convert.ToInt32(Console.ReadLine());
                                int numC = ncu.Next(1, 111111);
                                cuenta nuevocuenta = new cuenta(rutA, contA, saldoA, numC);
                                listaCuentas.Add(nuevocuenta);

                                Console.WriteLine("Cuenta Bancaria Creada exitosamente");
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    Rut: {nuevocuenta.Rut}");
                                Console.WriteLine($"    Saldo: ${nuevocuenta.Saldo}");
                                Console.WriteLine($"    N°Cuenta: {nuevocuenta.Id_cuente}");
                                Console.WriteLine($"    Contraseña: {nuevocuenta.Contraseña}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                            }
                            else
                            {
                                Console.WriteLine("┌────────────────────────────────────────────┐");
                                Console.WriteLine("│        NO ESTA REGISTRADO EN EL BANCO      │");
                                Console.WriteLine("│    REGISTRESE PARA PODER CREAR UNA CUENTA  │");
                                Console.WriteLine("└────────────────────────────────────────────┘");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│              Consulta de Saldo             │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.WriteLine("Ingrese RUT");
                        string rutB = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("ingrese clave de la cuenta ingresada: ");
                        int contB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        foreach (cuenta cuentas in listaCuentas)
                        {
                            if (cuentas.Contraseña == contB & cuentas.Rut == rutB)
                            {
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    N°Cuenta: {cuentas.Id_cuente}");
                                Console.WriteLine($"    Rut: {cuentas.Rut}");
                                Console.WriteLine($"    Saldo: ${cuentas.Saldo}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                            }
                            else { Console.WriteLine("La cuenta ingresada no existe o ingreso datos erroneos, intente nuevamente"); }
                        }
                        break;

                    case 4:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│                   depositar                │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese RUT");
                        string rutC = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("ingrese clave de la cuenta ingresada: ");
                        int contC = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("ingrese el numero de cuenta: ");
                        int ncua = Convert.ToInt32(Console.ReadLine());
                        foreach (cuenta cuentasa in listaCuentas)
                        {
                            if (cuentasa.Rut == rutC & cuentasa.Contraseña == contC & cuentasa.Id_cuente == ncua)
                            {
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    N°Cuenta: {cuentasa.Id_cuente}");
                                Console.WriteLine($"    Rut: {cuentasa.Rut}");
                                Console.WriteLine($"    Saldo: ${cuentasa.Saldo}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                                Console.Write("ingrese monto de dinero a depositar: $");
                                int depositoa = Convert.ToInt32(Console.ReadLine());
                                cuentasa.Saldo = cuentasa.Saldo + depositoa;

                                Console.WriteLine("Deposito hecho exitosamente");
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    N°Cuenta: {cuentasa.Id_cuente}");
                                Console.WriteLine($"    Saldo: ${cuentasa.Saldo}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                            }
                            else { Console.WriteLine("La cuenta ingresada no existe o ingreso datos erroneos, intente nuevamente"); }
                        }
                        break;

                    case 5:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│                     Giro                   │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.WriteLine();
                        Console.WriteLine("ingrese su rut");
                        string RutD = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("ingrese la clave de la cuenta: ");
                        int contD = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("ingrese el numero de cuenta");
                        int numA = Convert.ToInt32(Console.ReadLine());
                        foreach (cuenta cuentasb in listaCuentas)
                        {
                            if (cuentasb.Contraseña == contD & cuentasb.Rut == RutD & cuentasb.Id_cuente == numA)
                            {
                                Console.WriteLine(" ┌───────────────────────────────────┐");
                                Console.WriteLine($"    N°Cuenta: {cuentasb.Id_cuente}");
                                Console.WriteLine($"    Rut: {cuentasb.Rut}");
                                Console.WriteLine($"    Saldo: ${cuentasb.Saldo}");
                                Console.WriteLine(" └───────────────────────────────────┘");
                                Console.Write("ingrese monto de dinero a retirar: $");
                                int numeros = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (cuentasb.Saldo - numeros > 0)
                                {
                                    cuentasb.Saldo = (cuentasb.Saldo - numeros);
                                }
                                else
                                {
                                    Console.WriteLine("El monto que desea retirar exede el monto que tiene su cuenta");
                                    Console.WriteLine("Volviendo al menu principal");
                                }
                            }
                            else { Console.WriteLine("La cuenta ingresada no existe o ingreso datos erroneos, intente nuevamente"); }
                        }
                        break;

                    case 6:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│              Busqueda por rut              │");
                        Console.WriteLine("└────────────────────────────────────────────┘");

                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine(" Ingrese el tipo de usuario que buscar:");
                        Console.WriteLine(" 1.- Administrador");
                        Console.WriteLine(" 2.- Cliente");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.Write("Opcion: ");

                        int opcione = Convert.ToInt32(Console.ReadLine());
                        switch (opcione)
                        {
                            case 1:
                                Console.WriteLine("ingrese rut de administrador para ingresar: ");
                                string rutEda = Console.ReadLine();
                                foreach (administrador cuentaEA in listaAdmin)
                                {
                                    if (cuentaEA.Rut == rutEda)
                                    {
                                        Console.WriteLine("Ingrese rut de usuario que desea buscar: ");
                                        string rutAS = Console.ReadLine();
                                        foreach (cuenta cuentae in listaCuentas) foreach (administrador persoAD in listaAdmin)
                                            {
                                                if (cuentae.Rut == rutAS & persoAD.Rut == rutAS)
                                                {
                                                    Console.WriteLine($"Datos de Administrador");
                                                    Console.WriteLine(" ┌───────────────────────────────────┐");
                                                    Console.WriteLine($"    Nombre {persoAD.Nombre}");
                                                    Console.WriteLine($"    Apellido {persoAD.Apellido}");
                                                    Console.WriteLine($"    Rut: {cuentae.Rut}");
                                                    Console.WriteLine($"    Saldo: ${cuentae.Saldo}");
                                                    Console.WriteLine($"    N°Cuenta: {cuentae.Id_cuente}");
                                                    Console.WriteLine(" └───────────────────────────────────┘");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Los datos ingresados no son correctos o Cliente no existe en este banco");
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("No es admin no puede ver los datos"); }
                                }
                                break;

                            case 2:
                                Console.WriteLine("ingrese rut de administrador para ingresar: ");
                                string rutEd = Console.ReadLine();
                                foreach (administrador cuentaeA in listaAdmin)

                                {
                                    if (cuentaeA.Rut == rutEd)
                                    {
                                        Console.WriteLine("Ingrese rut de usuario que desea buscar: ");
                                        string rutAc = Console.ReadLine();
                                        foreach (cuenta cuentae in listaCuentas) foreach (cliente perso in listaCliente)
                                            {
                                                if (cuentae.Rut == rutAc & perso.Rut == rutAc)
                                                {
                                                    Console.WriteLine($"Datos de cliente");
                                                    Console.WriteLine(" ┌───────────────────────────────────┐");
                                                    Console.WriteLine($"    Nombre: {perso.Nombre}");
                                                    Console.WriteLine($"    Apellido: {perso.Apellido}");
                                                    Console.WriteLine($"    Rut: {cuentae.Rut}");
                                                    Console.WriteLine($"    Saldo: ${cuentae.Saldo}");
                                                    Console.WriteLine($"    N°Cuenta: {cuentae.Id_cuente}");
                                                    Console.WriteLine(" └───────────────────────────────────┘");
                                                }
                                                else { Console.WriteLine("Los datos ingresados no son correctos o Cliente no existe en este banco"); }
                                            }
                                        break;
                                    }
                                    else { Console.WriteLine("no es admin no puede ver los datos"); }
                                }
                                break;
                        }
                        break;

                    case 7:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│           Editar datos de usuario          │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine(" Ingrese el tipo de usuario que desea editar:");
                        Console.WriteLine(" 1.- Cliente");
                        Console.WriteLine(" 2.- Administrador");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Console.Write("Opcion: ");

                        int opci = Convert.ToInt32(Console.ReadLine());

                        switch (opci)
                        {
                            case 1:
                                Console.WriteLine("Ingrese Rut del cliente a editar");
                                string ruc = Console.ReadLine();

                                foreach (cuenta cuentaF in listaCuentas) foreach (cliente personaF in listaCliente)
                                    {
                                        if (cuentaF.Rut == ruc & cuentaF.Rut == ruc)
                                        {
                                            Console.WriteLine(" ┌───────────────────────────────────┐");
                                            Console.WriteLine("  Opciones de edicion                 ");
                                            Console.WriteLine("  1.-nombre                           ");
                                            Console.WriteLine("  2.-apellido                         ");
                                            Console.WriteLine("  3.-Contraseña cuenta                ");
                                            Console.WriteLine(" └───────────────────────────────────┘");
                                            int opciona = Convert.ToInt32(Console.ReadLine());

                                            switch (opciona)
                                            {
                                                case 1:
                                                    Console.WriteLine($"Nombre a Remplazar: {personaF.Nombre}");
                                                    Console.Write("Nuevo Nombre: ");
                                                    string nombreF = Console.ReadLine();
                                                    personaF.Nombre = nombreF;

                                                    Console.WriteLine($"El nuevo nombre asociado a la cuenta es: {personaF.Nombre}");
                                                    break;
                                                case 2:
                                                    Console.WriteLine($"Apellido a Remplazar: {personaF.Apellido}");
                                                    Console.Write("Nuevo Apellido: ");
                                                    string apellidoF = Console.ReadLine();
                                                    personaF.Apellido = apellidoF;
                                                    Console.WriteLine($"El nuevo apellido asociado a la cuenta es: {personaF.Apellido}");
                                                    break;

                                                case 3:
                                                    Console.WriteLine($"Clave a remplazar: {cuentaF.Contraseña}");
                                                    Console.Write("Nueva Clave: ");
                                                    int contraF = Convert.ToInt32(Console.ReadLine());
                                                    cuentaF.Contraseña = contraF;
                                                    Console.Write($"Clave remplazada por: {cuentaF.Contraseña}");
                                                    Console.Write("");
                                                    break;
                                            }
                                        }
                                        else Console.WriteLine("Los datos ingresados no son correctos o Cliente no existe en este banco");
                                    }
                                break;

                            case 2:
                                Console.WriteLine("Ingrese Rut del administrador que desea editar");
                                string runc = Console.ReadLine();

                                foreach (cuenta cuentaFo in listaCuentas) foreach (administrador adminad in listaAdmin)
                                    {
                                        if (cuentaFo.Rut == runc & cuentaFo.Rut == runc)
                                        {

                                            Console.WriteLine(" ┌───────────────────────────────────┐");
                                            Console.WriteLine("  Opciones de edicion                 ");
                                            Console.WriteLine("  1.-nombre                           ");
                                            Console.WriteLine("  2.-apellido                         ");
                                            Console.WriteLine("  3.-Contraseña cuenta                ");
                                            Console.WriteLine(" └───────────────────────────────────┘");
                                            int opciona = Convert.ToInt32(Console.ReadLine());
                                            switch (opciona)
                                            {
                                                case 1:
                                                    Console.WriteLine($"Nombre a Remplazar: {adminad.Nombre}");
                                                    Console.Write("Nuevo Nombre:");
                                                    string nombreF = Console.ReadLine();
                                                    adminad.Nombre = nombreF;

                                                    Console.WriteLine($"el nuevo nombre asociado a la cuenta es: {adminad.Nombre}");
                                                    break;
                                                case 2:
                                                    Console.WriteLine($"Apellido a Remplazar: {adminad.Apellido}");
                                                    Console.Write("Nuevo Apellido");
                                                    string apellidoF = Console.ReadLine();
                                                    adminad.Apellido = apellidoF;
                                                    Console.WriteLine($"el nuevo apellido asociado a la cuenta es: {adminad.Apellido}");
                                                    break;

                                                case 3:
                                                    Console.WriteLine($"Clave a remplazar: {cuentaFo.Contraseña}");
                                                    Console.Write("Nueva Clave: ");
                                                    int contraF = Convert.ToInt32(Console.ReadLine());
                                                    cuentaFo.Contraseña = contraF;
                                                    break;
                                            }
                                        }
                                        else Console.WriteLine("Los datos ingresados no son correctos o Cliente no existe en este banco");
                                    }
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│                   ADIOS                    │");
                        Console.WriteLine("│            QUE TENGA BUEN DIA              │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("┌────────────────────────────────────────────┐");
                        Console.WriteLine("│                OPCION ERRONEA              │");
                        Console.WriteLine("│        POR FAVOR INGRESE OPCION VALIDA     │");
                        Console.WriteLine("└────────────────────────────────────────────┘");
                        break;
                }
            }
        }
    }
}
