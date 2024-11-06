class Escape 
{
    // Estructura para almacenar las opciones y la respuesta correcta para cada sala
    private static string[][] incognitasSalas = new string[][]
    {
        // Formulario 1: Configuración de Dispositivos de Red
        new string[] { "Switch", "Servidor de conexión", "Router", "2" }, // Respuesta correcta es la opción 3 (índice 2)
        new string[] { "Asignar direcciones IP dinámicas", "Conectar dispositivos y enviar datos al destino correcto", "Proteger la red", "1" }, // Respuesta correcta es la opción 2 (índice 1)
        new string[] { "Dirección IP", "Marca del router", "Color del dispositivo", "0" }, // Respuesta correcta es la opción 1 (índice 0)

        // Formulario 2: Direccionamiento IP
        new string[] { "4", "8", "16", "0" }, 
        new string[] { "10.0.0.0", "10.0.0.5", "255.255.0.0", "0" }, 
        new string[] { "Clase A", "Clase B", "Clase C", "2" }, 

        // Formulario 3: Protocolos de Comunicación
        new string[] { "Dynamic Host Control Protocol", "Dynamic Host Configuration Protocol", "Distributed Hypertext Communication Protocol", "1" }, // Respuesta correcta es la opción 2 (índice 1)
        new string[] { "TCP (Transmission Control Protocol)", "UDP (User Datagram Protocol)", "HTTP (Hypertext Transfer Protocol)", "0" }, // Respuesta correcta es la opción 1 (índice 0)
        new string[] { "Aplicación, transporte, Internet, interfaz de red", "Aplicación, presentación, Internet, interfaz de red", "Aplicación, enlace de datos, Internet, interfaz de red", "0" } // Respuesta correcta es la opción 1 (índice 0)
    };

    // Array de pistas por cada sala (pregunta)
    private static string[][] pistas = new string[][]
    {
        // Formulario 1: Configuración de Dispositivos de Red
        new string[] {
            "Este dispositivo es utilizado para conectar diferentes redes, asegurando que los paquetes de datos lleguen a su destino correcto, incluso si están en redes distintas.",
            "Este dispositivo es clave para realizar comunicaciones entre redes de áreas geográficas diferentes.",
            "Este dispositivo se usa para enviar datos de una red a otra, basándose en la dirección IP de destino."
        },
        new string[] {
            "Este dispositivo ayuda a que los dispositivos dentro de una misma red se comuniquen entre sí.",
            "En lugar de enviar datos a todos los dispositivos, este dispositivo los manda solo al que debe recibirlos.",
            "Este dispositivo se usa para conectar computadoras, impresoras y otros dispositivos dentro de una oficina o casa."
        },
        new string[] {
            "Esta información permite que el router se identifique en una red y se comunique con otros dispositivos a través de Internet o una red local.",
            "Es una serie de números únicos que se asigna a cada dispositivo para que pueda ser localizado y contactado dentro de una red.",
            "Sin esta información, los dispositivos de la red no sabrían a qué dirección enviar los paquetes de datos, lo que impediría la comunicación."
        },

        // Formulario 2: Direccionamiento IP
        new string[] {
            "Esta máscara de subred, 255.255.255.192, utiliza 2 bits adicionales para las subredes, lo que significa que las opciones disponibles se limitan a ciertos números.",
            "Cuando divides una red de clase C utilizando esta máscara, cada subred creada tendrá un número de direcciones limitado por los bits tomados prestados.",
            "Recuerda que el número total de subredes posibles se calcula con 2 elevado al número de bits adicionales que se utilizan para la subred."
        },
        new string[] {
            "La dirección de red siempre tiene ceros en los bits que corresponden a los dispositivos dentro de la red.",
            "Si usas la máscara 255.255.0.0, eso significa que los primeros dos grupos de números en la IP no cambian y los otros se convierten en cero.",
            "La dirección de red es la más baja de todas las direcciones posibles dentro de la subred."
        },
        new string[] {
            "El primer octeto de una dirección IP en una red determinada afecta tanto al tamaño de la red como al número de hosts disponibles dentro de esa red.",
            "Si consideras las primeras tres clases de direcciones IP, hay una en la que el rango de direcciones para hosts es más pequeño, pero aún permite suficientes dispositivos para oficinas y pequeñas redes.",
            "La clasificación de las direcciones IP sigue un esquema basado en los primeros bits, y la clase que te interesa es aquella en la que el primer bit de la dirección está entre 11000000 y 11011111."
        },

        // Formulario 3: Protocolos de Comunicación
        new string[] {
            "Este protocolo es fundamental en redes donde se desea facilitar la conexión de dispositivos sin la necesidad de configurar manualmente cada uno de ellos.",
            " El nombre de este protocolo tiene que ver con cómo los dispositivos obtienen información clave, como direcciones IP, para unirse a una red, pero no implica un control exhaustivo de las máquinas.",
            "Este protocolo es comúnmente utilizado en redes de área local (LAN) y se refiere a una técnica de configuración automática de dispositivos para que se comuniquen sin intervención humana.",
        },
        new string[] {
            "Este protocolo es conocido por su fiabilidad, ya que garantiza que los datos lleguen completos y en el orden correcto, reintentando la transmisión si es necesario.",
            "A diferencia de otros protocolos, este realiza una verificación exhaustiva y controlada de la entrega de datos, asegurando la integridad de la transferencia.",
            "Este protocolo se utiliza frecuentemente en aplicaciones donde la precisión y la fiabilidad son más importantes que la velocidad, como en transferencias de archivos grandes."
        },
        new string[] {
            "Este modelo de capas es más simple que el modelo OSI, con un enfoque en cómo los dispositivos se comunican a través de diferentes redes, utilizando menos capas.",
            "Una de las capas de este modelo se encarga de establecer la comunicación entre aplicaciones, mientras que otra gestiona el transporte y la entrega fiable de los datos.",
            "Este modelo tiene cuatro capas principales, pero una de ellas se enfoca en la parte de comunicación directa con el hardware de la red."
        }
    };
    private static string[] preguntas = new string[] {
        // Formulario 1: Configuración de Dispositivos de Red
        "Un administrador de red necesita conectar varias sucursales de una empresa. ¿Qué tipo de dispositivo utilizaría para interconectar redes diferentes y garantizar la comunicación entre ellas?",
        "¿Cuál de las siguientes opciones describe mejor la función de un switch en una red?",
        "Al configurar un router en Packet Tracer, ¿qué información es esencial para establecer la conexión con otros dispositivos?",

        // Formulario 2: Direccionamiento IP
        "Tenés que diseñar una red que contenga 50 dispositivos. Si decidís usar direcciones IP de clase C, ¿cuántas subredes podés crear utilizando la máscara 255.255.255.192?",
        "Si en Packet Tracer configuras un dispositivo con una dirección IP de 10.0.0.5 y una máscara de subred de 255.255.0.0, ¿cuál es la dirección de red correspondiente?",
        "Una dirección IP está compuesta por cuatro octetos. Si el primer octeto de una dirección IP es 192, ¿a qué clase de dirección pertenece?",

        // Formulario 3: Protocolos de Comunicación
        "¿Qué significan las siglas DHCP?",
        "¿Qué protocolo se utiliza comúnmente para la transferencia de archivos en una red, garantizando la entrega completa de datos?",
        "¿Qué capas tiene el modelo TCP/IP?"
    };

    private static int estadoJuego = 0;

    public static int GetEstadoJuego()
    {
        if(estadoJuego == 0) 
        {
            estadoJuego = 1;
        }
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, int respuesta)
    {
        var incognita = incognitasSalas[sala - 1][respuesta];
        var realIndex = int.Parse(incognitasSalas[sala - 1][3]);
        if (incognitasSalas[sala-1][realIndex] == incognita)
        {
            estadoJuego++;
            return true;
        }
        return false;
    }

    // Método para obtener las opciones de la sala
    public static (string, string, string) ObtenerOpcionesSala(int sala)
    {
        var opciones = incognitasSalas[sala - 1];
        if (opciones.Length == 4)
        {
            return (opciones[0], opciones[1], opciones[2]);
        }
        else
        {
            
            return ("", "", "");
        }
    }

    public static (string, string, string) ObtenerPistasSala(int sala)
    {
        var opciones = pistas[sala - 1];

        // Verifica que hay suficientes pistas antes de acceder a ellas
        if (opciones.Length >= 3)
        {
            return (opciones[0], opciones[1], opciones[2]);
        }
        else
        {
            return ("", "", ""); // Devuelve valores vacíos si no hay suficientes pistas
        }
    }

    public static string ObtenerPreguntaSala(int sala)
    {   
        return preguntas[sala - 1];
    }
}

