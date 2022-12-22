using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace LearnKode
{
    public partial class TutorialTEA : Form
    {
        int a = 0;
        int tutoN = 0;
        public TutorialTEA(int numTuto)
        {
            InitializeComponent();
            tryBtn.Hide();
            tutoN = numTuto;
            switch (numTuto)
            {
                case 1:
                    Texto();
                    tutoN = 1;
                    break;
                case 2:
                    tutoN = 2;
                    tutoVariables();
                    break;
                case 3:
                    tutoN = 3;
                    tutoDatos();
                    break;
                case 4:
                    tutoN = 4;
                    tutoOperadores();
                    break;
                case 5:
                    tutoN = 5;
                    tutoScanner();
                    break;
                case 6:
                    tutoN = 6;
                    tutoString();
                    break;
                case 7:
                    tutoN = 7;
                    tutoIf();
                    break;
                case 8:
                    tutoN = 8;
                    tutoSwitch();
                    break;
                case 9:
                    tutoN = 9;
                    tutoWhile();
                    break;
                case 10:
                    tutoN = 10;
                    tutoDoWhile();
                    break;
                case 11:
                    tutoN = 11;
                    tutoFor();
                    break;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MenuTutos abrirPantallaCarga = new MenuTutos();
            abrirPantallaCarga.Show();
            this.Hide();
        }
        private void PictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void PictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void Actualizar()
        {
            switch (tutoN)
            {
                case 1:
                    Texto();
                    break;
                case 2:
                    tutoVariables();
                    break;
                case 3:
                    tutoDatos();
                    break;
                case 4:
                    tutoOperadores();
                    break;
                case 5:
                    tutoScanner();
                    break;
                case 6:
                    tutoString();
                    break;
                case 7:
                    tutoIf();
                    break;
                case 8:
                    tutoSwitch();
                    break;
                case 9:
                    tutoWhile();
                    break;
                case 10:
                    tutoDoWhile();
                    break;
                case 11:
                    tutoFor();
                    break;
            }
        }
        public void Texto()
        {
            if (a >= 3) { a = 3; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "¡Hola! Ponte comodo y lee atentamente por favor. \nHoy vas a conocer un poco sobre el lenguaje de programación java" +
                    "Piensa en un rompecabezas, para completarlo debes de colocar todas las piezas de forma correcta, con la programación tambien";
                    imagenTuto.Image = Properties.Resources.tutoTEA1;
                    break;
                case 1:
                    label1.Text = "Mira bien la estructura del programa. \nEn color Azul celeste estan resaltadas las palabras reservadas" +
                    ", necesarias para iniciar el programa. Lo señalado en rojo es el nombre que le damos" +
                    "\nLas flechas naranjas indican dónde empieza y termina el programa";
                    imagenTuto.Image = Properties.Resources.tuto1;
                    break;
                case 2:
                    label1.Text = "Las siguientes palabras señaladas en Azul también son reservadas. \nEn color Verde está una cadena necesaria para la signatura del programa" +
                        ", después están las llaves señaladas con color marrón, lo que escribimos aquí es lo que hará el programa" +
                    "\nEn este caso es algo muy sencillo, imprimir un mensaje";
                    imagenTuto.Image = Properties.Resources.tuto2;
                    break;
                case 3:
                    label1.Text = "La cadena señalada en amarillo es un método necesario para imprimir mensajes. \nEn color Azul está y entre comillas está el mensaje que queremos imprimir" +
                        ", por último están el punto y coma, estos definen el final de un metodo o instrucción." +
                    "\n!Lo has hecho bien! Más adelante veremos que es un metodo entre otros conceptos, no te preocupes";
                    imagenTuto.Image = Properties.Resources.tuto3;
                    tryBtn.Visible = true;
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {
                        MainForm tutoHola = new MainForm();
                        tutoHola.HolaMundo();
                        tutoHola.Show();
                    };
                    break;

            }
        }
        public void tutoVariables()
        {
            if (a >= 1) { a = 1; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    imagenTuto.Location = new System.Drawing.Point(183, 42);
                    imagenTuto.Size = new System.Drawing.Size(524, 525);
                    label1.Dispose();
                    label1.Text = "¡Hola! Ponte comodo y lee atentamente por favor. \nHoy vas a conocer un poco sobre el lenguaje de programación java" +
                    "Piensa en un rompecabezas, para completarlo debes de colocar todas las piezas de forma correcta, con la programación tambien";
                    imagenTuto.Image = Properties.Resources.variables_a;
                    break;
            }
        }
        public void tutoDatos()
        {
            if (a >= 4) { a = 4; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "char - Los chars son piezas de rompecabezas. \nQue si las miras detalladamente podrás observar que cada una tiene un carácter (un signo, numero o letra) simple." +
                    "\nPara declarar una variable de tipo char es necesario colocar el nombre del tipo de dato que en este caso será “char” seguido del nombre de tu variable el cual en el primer ejemplo es “A”" +
                    "\nDespues se asigna el valor con el simbolo '=' y por último el valor.";
                    imagenTuto.Image = Properties.Resources.datos_a;
                    break;
                case 1:
                    label1.Text = "int - los ints son cantidades como la cantidad de piezas de un rompecabezas, cada uno tiene un valor numérico." +
                    "\nPara declarar una variable de tipo int es necesario colocar el nombre del tipo de dato que en este caso será “int” seguido del nombre de tu variable" +
                    "\nDespues se asigna el valor con el simbolo '=' y por último el valor.";
                    imagenTuto.Image = Properties.Resources.datos_b;
                    break;
                case 2:
                    label1.Text = "double – como el precio de los rompecabezas, a veces son números enteros como $ 123, pero a veces se necesita un poco más sin ser un número entero, por ejemplo, $ 123.5. Los doubles son eso, cantidades que contienen puntos decimales." +
                    "\nPara declarar una variable de tipo double es necesario colocar el nombre del tipo de dato que en este caso será “double” seguido del nombre de tu variable." +
                    "\nDespues se asigna el valor con el simbolo '=' y por último el valor.";
                    imagenTuto.Image = Properties.Resources.datos_c;
                    break;
                case 3:
                    label1.Text = "string - “string” significa cuerda en inglés. Realmente los strings no son más que rompecabezas ensamblados que hemos juntado entre comillas dobles para mantener juntos y en orden algunos grupos de chars que no queremos tener sueltos, sería una lástima que se nos desarmen." +
                    "\nPara declarar una variable de tipo string es necesario colocar el nombre del tipo de dato que en este caso será “String” seguido del nombre de tu variable." +
                    "\nDespues se asigna el valor con el simbolo '=' y por último el valor.";
                    imagenTuto.Image = Properties.Resources.datos_d;
                    break;
                case 4:
                    label1.Text = "boolean - los booleanos son como las piezas del rompecabezas que tiene solo dos caras: la delantera y la trasera, las cuales aquí llamamos True y False. Quizá ahora te preguntes qué utilidad tienen, en el futuro lo irás descubriendo." +
                    "\nPara declarar una variable de tipo boolean es necesario colocar el nombre del tipo de dato que en este caso será “boolean” seguido del nombre de tu variable." +
                    "\nDespues se asigna el valor con el simbolo '=' y por último el valor.";
                    imagenTuto.Image = Properties.Resources.datos_e;
                    break;

            }
        }
        public void tutoOperadores()
        {
            if (a >= 1) { a = 1; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    imagenTuto.Location = new System.Drawing.Point(183, 42);
                    imagenTuto.Size = new System.Drawing.Size(524, 525);
                    label1.Dispose();
                    label1.Text = "¡Hola! Ponte comodo y lee atentamente por favor. \nHoy vas a conocer un poco sobre el lenguaje de programación java" +
                    "Piensa en un rompecabezas, para completarlo debes de colocar todas las piezas de forma correcta, con la programación tambien";
                    imagenTuto.Image = Properties.Resources.Operadores_a;
                    break;
                case 1:
                    imagenTuto.Image = Properties.Resources.Operadores_b;
                    break;
            }
        }
        public void tutoScanner()
        {
            if (a >= 2) { a = 2; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "Vamos a conocer la clase Scanner (una clase es como una caja de un rompecabezas, en donde adentro están las distintas piezas que necesitaremos en este mismo) que contiene el método Scanner." +
                    "\nEste poderoso método nos da la oportunidad de hablarle al programa desde el teclado, mientras se está ejecutando." +
                    "\nPrimero tenemos que agregarla a nuestro programa, decirle que vamos a usar esa caja. Y eso se hace añadiendo esta indicación al principio del programa:'import java.util.Scanner;'";
                    imagenTuto.Image = Properties.Resources.scanner_a;
                    break;
                case 1:
                    label1.Text = "Una ves importada la clase es como si abriéramos dicha caja de rompecabezas en donde encontraremos las distintas piezas." +
                    "\nAhora para poder utilizar Scanner necesitamos lo siguiente:" +
                    "\nCrear un nuevo Scanner y darle el nombre que mas nos convenga e ingresándole una cadena de texto como se muestra a continuación.";
                    imagenTuto.Image = Properties.Resources.scanner_b;
                    break;
                case 2:
                    label1.Text = "Para crear el Scanner indicamos que crearemos un Scanner con esta misma palabra Scanner, después le daremos un nombre." +
                    "\nEn este caso será leer para hacer alusión a que la computadora leerá lo que ingresemos en el teclado, seguido de lo siguiente = new Scanner (System.in)" +
                    "\nPor último, para asignarle el valor que introduzcamos desde nuestro teclado a una variable que necesitemos tendremos que hacer la siguiente línea según el tipo de dato de nuestra variable como se muestra a continuación.";
                    imagenTuto.Image = Properties.Resources.scanner_c;
                    tryBtn.Visible = true;
                    MainForm tutoScanner = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoScanner.Scanner();
                        tutoScanner.Show();
                    };
                    break;
            }
        }
        public void tutoString()
        {
            if (a >= 2) { a = 2; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "Vamos a conocer uno de los metodos de la clase String" +
                    "\nEste  método nos da la oportunidad de medir de forma numerica la cantidad de caracteres que tiene el texto que almacenamos en una variable." +
                    "\nPrimero crearemos el mensaje del cual contaremos la cantidad de caracteres, en este caso un String";
                    imagenTuto.Image = Properties.Resources.string_a;
                    break;
                case 1:
                    label1.Text = "Después crearemos una variable int en la cual colocaremos el número de caracteres que tiene el mensaje.";
                    imagenTuto.Image = Properties.Resources.string_b;
                    break;
                case 2:
                    label1.Text = "Por último, mostraremos en pantalla con ayuda de un System.out.println(); y concatenando con un + una frase en la cual nos diga el numero de caracteres que tenga nuestro string como se muestra.";
                    imagenTuto.Image = Properties.Resources.string_c;
                    tryBtn.Visible = true;
                    MainForm tutoString = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoString.String();
                        tutoString.Show();
                    };
                    break;
            }
        }
        public void tutoIf()
        {
            if (a >= 8) { a = 8; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "Para entender mejor estas estructuras piensa en ellas como un circuito electrico, si permites que la corriente pase los focos se encenderan." +
                    "\nSi evitas que pase la corriente, los focos estáran apagados." +
                    "\nEntonces, con la instrucción “IF” podemos hacer que el programa efectúe una acción “SI” una condición se cumple." +
                    " Y si no se cumple… ¿Qué hacemos? Para eso establecemos un camino secundario, si no es una cosa, será la otra. Es decir, un bloque de código concreto al que sólo se entra si NO se cumple la instrucción: a este bloque le llamamos ELSE.";
                    imagenTuto.Image = Properties.Resources.if_a;
                    break;
                case 1:
                    label1.Text = "En el siguiente código veremos una instrucción IF- ELSE, el programa guardará el valor de la temperatura en una variable." +
                    "\nDespués evaluará si es superior a 3 grados, y si es así nos va a alertar de que algo no está como debería." +
                    "\nEn cambio, si la temperatura es inferior (es decir, en cualquier otro caso) nos muestra otro mensaje que confirma que está enfriando como debería.";
                    imagenTuto.Image = Properties.Resources.if_a;
                    break;
                case 2:
                    label1.Text = "Como hemos visto anteriormente iniciamos primero con el “public class” seguido del nombre que se le pondrá al programa " +
                        "“Estructura_if” y para finalizar utilizando las llaves de apertura y cierre estableciendo el comienzo y el final del programa, dentro irán las " +
                        "instrucciones del código.";
                    imagenTuto.Image = Properties.Resources.if_b;
                    break;
                case 3:
                    label1.Text = "La siguiente línea es “public satic void main(String [] args)”, ya que es el encabezado de la clase para que funcione el programa.";
                    imagenTuto.Image = Properties.Resources.if_c;
                    break;
                case 4:
                    label1.Text = "La siguiente línea es la librería Scanner, ella se encargará de cuando ingrese los datos por teclado se almacenen en la variable que declares." +
                        " Es importante que para su uso verifiques que se encuentre importada la librería.";
                    imagenTuto.Image = Properties.Resources.if_d;
                    break;
                case 5:
                    label1.Text = "En la siguiente línea estamos declarando la variable de tipo entero “int” con el nombre “temperaturaNevera” con " +
                        " valor 0 para que no halla problema al momento de utilizarla.";
                    imagenTuto.Image = Properties.Resources.if_e;
                    break;
                case 6:
                    label1.Text = "Después procedemos a leer por teclado el valor que tomara nuestra variable “temperaturaNevera”, que de pasar a valer 0 " +
                        "tomara el valor que le ingresemos.";
                    imagenTuto.Image = Properties.Resources.if_f;
                    break;
                case 7:
                    label1.Text = "Una vez tenga el nuevo valor la variable entraremos a la estructura if en la cual se pondrá la condicional que se " +
                        "debe cumplir, en este caso “4 <= temperaturaNevera” para que el programa imprima la frase “La temperatura en la nevera es " +
                        "demasiado alta!!! + \nLa temperatura es de  + 'temperaturaNevera' + 'º grados'";
                    imagenTuto.Image = Properties.Resources.if_g;
                    break;
                case 8:
                    label1.Text = "Para finalizar en caso de que la condición no se cumpla y que el valor asignado a la variable sea menor a 4 entrará " +
                        "en el else y nos imprimirá en pantalla el mensaje 'Nevera enfriando correctamente'.";
                    imagenTuto.Image = Properties.Resources.if_h;
                    tryBtn.Visible = true;
                    MainForm tutoIf = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoIf.If();
                        tutoIf.Show();
                    };
                    break;
            }
        }
        public void tutoSwitch()
        {

            if (a >= 8) { a = 8; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "SWITCH significa interruptor en inglés, y su función es interrumpir el paso de todas las instrucciones que no cumplan las condiciones iniciales.\n" +
                    "\nVeamos el siguiente ejemplo para que lo comprendas mejor, el programa guardara el valor de a y b, después te preguntara que deseas realizar con dichos valores" +
                    "\nalmacenados si deseas sumar, multiplicar o dividir, dependiendo de la opción elegida se guardara en otra variable y después te redirigirá a la opción elegida" +
                    "\narrojándote el resultado de la operación elegida y finalizara el programa.";
                    imagenTuto.Image = Properties.Resources.switch_a;
                    break;
                case 1:
                    label1.Text = "Iniciamos con la declaración de la clase 'public class Estrictura_Switch' recuerda que se deben utilizar la llave de apertura y cierre para indicar el principio y el fin de la clase.";
                    imagenTuto.Image = Properties.Resources.switch_b;
                    break;
                case 2:
                    label1.Text = "La siguiente línea es 'public satic void main(String [] args), ya que es el encabezado de la clase para que funcione el programa.";
                    imagenTuto.Image = Properties.Resources.switch_c;
                    break;
                case 3:
                    label1.Text = "La siguiente línea es la librería Scanner, ella se encargará de cuando se ingresen los datos por teclado se almacenen en la variable que se declare." +
                    "\nEs importante que para su uso verifiques que se encuentre importada la librería.";
                    imagenTuto.Image = Properties.Resources.switch_d;
                    break;
                case 4:
                    label1.Text = "En esta imagen se declararán las variables que utilizaremos en el programa.";
                    imagenTuto.Image = Properties.Resources.switch_e;
                    break;
                case 5:
                    label1.Text = "Una vez declaradas las variables en la siguiente línea se pedirá el valor de 'a', después procedemos a leer por teclado el valor que tomará" +
                "nuestra variable 'a'. Realizaremos el mismo procedimiento para la variable 'b'.";
                    imagenTuto.Image = Properties.Resources.switch_f;
                    break;
                case 6:
                    label1.Text = "Una vez ingresado el valor de ambas variables, en la siguiente línea te dará opciones de que operación quieres realizar con los valores ingresados," +
                "(1 si quieres sumar, 2 si quieres multiplicar y 3 si quieres dividir) y según el numero elegido se guardara en la variable 'op'";
                    imagenTuto.Image = Properties.Resources.switch_g;
                    break;
                case 7:
                    label1.Text = "Una vez seleccionado una opción, se inicia la sentencia switch y usaremos como parámetro la variable 'op' la cual se encargará de comparar cada caso";
                    imagenTuto.Image = Properties.Resources.switch_h;
                    break;

                case 8:
                    label1.Text = "Cada caso es una opción, el 'case 1: se encarga de realizar la suma', el 'case 2: se encarga de realizar la multiplicación' y el 'case 3: se encarga de realizar la división'" +
                    "y según 'op' se ejecutara uno de los casos arrojando el valor de la operación guardándola en una variable llamada 'res', mostrándola en consola y terminando el programa";
                    imagenTuto.Image = Properties.Resources.switch_i;
                    tryBtn.Visible = true;
                    MainForm tutoSwitch = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoSwitch.Switch();
                        tutoSwitch.Show();
                    };
                    break;
            }
        }
        public void tutoWhile()
        {
            if (a >= 7) { a = 7; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "Una declaración while evalúa el valor de una condición, ejecutando el código que contiene siempre que la condición sea verdadera." +
                    "\nUna vez que la verificación encuentra que la condición se evalúa como falsa, se dejara de ejecutar el bloque de código y continúa con el resto del programa en caso de haberlo.";
                    imagenTuto.Image = Properties.Resources.while_a;
                    break;
                case 1:
                    label1.Text = "Recuerda:\n" +
                    "\nSi la condición es falsa en el paso 1, nunca ejecutará el bloque de código, ni lo verificará nuevamente; irá directamente a la siguiente tarea." +
                    "\nSi el valor de la condición nunca cambia, tendremos un bucle infinito. El bloque nunca dejará de ejecutarse.";
                    imagenTuto.Image = Properties.Resources.while_a;
                    break;
                case 2:
                    label1.Text = "Para que lo comprendas mejor veremos el siguiente ejemplo, en el cual ingresaremos por teclado el valor de una variable llamada 'a'," +
                    "después en el bucle while visualiza el valor actual de 'a', incrementando su valor en uno y repitiéndose el ciclo, hasta que el valor de digito sea" +
                    "menor a 10 y el programa finaliza, si el valor ingresado de 'a' desde un inicio es mayor a 10 el ciclo se ropera ya que no cumple con la condición y el programa finaliza.";
                    imagenTuto.Image = Properties.Resources.while_b;
                    break;
                case 3:
                    label1.Text = "Iniciamos con la declaración de la clase 'public class Estrictura_While' recuerda que se deben utilizar la llave de apertura y cierre para indicar el principio y el fin de la clase.";
                    imagenTuto.Image = Properties.Resources.while_c;
                    break;
                case 4:
                    label1.Text = "La siguiente línea es 'public satic void main(String [] args)'', ya que es el encabezado de la clase para que funcione el programa.";
                    imagenTuto.Image = Properties.Resources.while_d;
                    break;
                case 5:
                    label1.Text = "La siguiente línea es la librería Scanner, ella se encargará de cuando se ingresen los datos por teclado se almacenen en la variable que se declare." +
                "\nEs importante que para su uso verifiques que se encuentre importada la librería.";
                    imagenTuto.Image = Properties.Resources.while_e;
                    break;
                case 6:
                    label1.Text = "Después procedemos a leer por teclado el valor que tomara nuestra variable 'a', que tomara el valor que le ingresemos por teclado.";
                    imagenTuto.Image = Properties.Resources.while_f;
                    break;
                case 7:
                    label1.Text = "En la siguiente línea el bucle while evaluara la siguiente condición 'a < 10', es decir si 'a' es menor a 10, el bucle se ejecutará" +
                "aumentando el valor de 'a' de uno en uno (a++) hasta llegar a 9 y finalizara el programa, en caso de que no se cumpla esta condición y" +
                "el valor de 'a' se mayor que 10 el programa no entrara en el bucle y se finalizara el programa.";
                    imagenTuto.Image = Properties.Resources.while_g;
                    tryBtn.Visible = true;
                    MainForm tutoWhile = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoWhile.While();
                        tutoWhile.Show();
                    };
                    break;
            }
        }
        public void tutoDoWhile()
        {
            if (a >= 7) { a = 7; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "La sentencia Do-While es muy parecida a la sentencia While pero se diferencia en que primero se inicia la ejecución del bloque de instrucciones y" +
                    "después se comprueba el valor de la condición. Dicho de otro modo, pase lo que pase siempre se va a ejecutar al menos una vez.";
                    imagenTuto.Image = Properties.Resources.dowhile_a;
                    break;
                case 1:
                    label1.Text = "Iniciamos con la declaración de la clase 'public class Estrictura_Dowhile' recuerda que se deben utilizar la llave de apertura y cierre para indicar el principio y el fin de la clase.";
                    imagenTuto.Image = Properties.Resources.dowhile_b;
                    break;
                case 2:
                    label1.Text = "La siguiente línea es 'public satic void main(String [] args)', ya que es el encabezado de la clase para que funcione el programa.";
                    imagenTuto.Image = Properties.Resources.dowhile_c;
                    break;
                case 3:
                    label1.Text = "La siguiente línea es la librería Scanner, ella se encargará de cuando se ingresen los datos por teclado se almacenen en la variable que se declare. Es importante que para su uso verifiques que se encuentre importada la librería.";
                    imagenTuto.Image = Properties.Resources.dowhile_d;
                    break;
                case 4:
                    label1.Text = "Procederemos a declarar nuestra variable de tipo entero 'int' llamada 'i'.";
                    imagenTuto.Image = Properties.Resources.dowhile_e;
                    break;
                case 5:
                    label1.Text = "Después procedemos a leer por teclado el valor que tomara nuestra variable 'i', que tomara el valor que le ingresemos por teclado.";
                    imagenTuto.Image = Properties.Resources.dowhile_f;
                    break;
                case 6:
                    label1.Text = "En la siguiente línea entraremos al 'do' en el cual solo se estará imprimiendo el valor de 'i' de uno en uno hasta que sea menor a 10.";
                    imagenTuto.Image = Properties.Resources.dowhile_g;
                    break;
                case 7:
                    label1.Text = "En el bucle 'while' se evaluará la siguiente condición 'i < 10', es decir si 'i' es menor a 10, entrara al 'do' y se imprimirá el valor de 'i' de uno en uno (i++) hasta llegar a 9 y finalizara el programa," +
                    "en caso de ser falso entrara aun quesea una sola vez, pero solo se imprimirá el valor ingresado y finaliza el programa.";
                    imagenTuto.Image = Properties.Resources.dowhile_h;
                    tryBtn.Visible = true;
                    MainForm tutoDoWhile = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoDoWhile.DoWhile();
                        tutoDoWhile.Show();
                    };
                    break;
            }
        }
        public void tutoFor()
        {
            if (a >= 7) { a = 7; }
            if (a <= 0) { a = 0; }
            switch (a)
            {
                case 0:
                    label1.Text = "La sentencia for nos sirve para programar bucles indicados para aquellos casos en que sabemos el número de veces que debemos iterar (dar vueltas al bloque de código)." +
                                            "\nPara ello, se define una variable con un valor numérico inicial, otra con el valor máximo a alcanzar y se indica que cada vez que se ejecuta el bloque, se suma uno a la primera. Cuando ha sumado tantos como el máximo, deja de iterar.";
                    imagenTuto.Image = Properties.Resources.for_a;
                    break;
                case 1:
                    label1.Text = "Iniciamos con la declaración de la clase 'public class Estrictura_For' recuerda que se deben utilizar la llave de apertura y cierre para indicar el principio y el fin de la clase.";
                    imagenTuto.Image = Properties.Resources.for_b;
                    break;
                case 2:
                    label1.Text = "La siguiente línea es 'public satic void main(String [] args)'', ya que es el encabezado de la clase para que funcione el programa.";
                    imagenTuto.Image = Properties.Resources.for_c;
                    break;
                case 3:
                    label1.Text = "La siguiente línea es la librería Scanner, ella se encargará de cuando se ingresen los datos por teclado se almacenen en la variable que se declare. Es importante que para su uso verifiques que se encuentre importada la librería.";
                    imagenTuto.Image = Properties.Resources.for_d;
                    break;
                case 4:
                    label1.Text = " Procederemos a declarar nuestra variable de tipo entero “int” llamada 'x'.";
                    imagenTuto.Image = Properties.Resources.for_e;
                    break;
                case 5:
                    label1.Text = "Después procedemos a leer por teclado el valor que tomara nuestra variable 'x', que tomara el valor que le ingresemos por teclado.";
                    imagenTuto.Image = Properties.Resources.for_f;
                    break;
                case 6:
                    label1.Text = "Una vez ingresado el valor asignado a 'x' pasaremos al bucle 'for' en donde evaluaremos la condición 'int i =0; x <= 20; x++', es decir que si el valor asignado 'x' es menor o igual a 20 entra, si no finaliza el programa.";
                    imagenTuto.Image = Properties.Resources.for_g;
                    break;
                case 7:
                    label1.Text = "Una vez se evalúa la condición si es verdadero entra en el 'for' y se imprime en consola los números desde el que se ingreso hasta el 20, en caso de ser falso se finaliza el programa. ";
                    imagenTuto.Image = Properties.Resources.for_h;
                    tryBtn.Visible = true;
                    MainForm tutoFor = new MainForm();
                    tryBtn.Click += delegate (object dender, EventArgs e)
                    {

                        tutoFor.For();
                        tutoFor.Show();
                    };
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            Actualizar();
            label1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a--;
            Actualizar();
            label1.Refresh();
        }
    }
}
