

using System;
using Proyecto_Final.Clases;
using Proyecto_Final.Interface;


namespace Proyecto_Final;

public partial class MainPage : ContentPage
{
    int Encendido = 0;
    int Encendido2 = 0;
    int Encendido3 = 0;
    int Encendido4 = 0;
    int Encendido5 = 0;
    int velocidad = 37;
    int VelocidadActual = 37;
    int VelocidadMaxima = 230;
    int baul = 0;
    int capo = 0;


    private VehiculoBase Started;
    private Pick_Up one;
    private Sedan two;
    private SUV three;
    private _4x4 four;
    public MainPage()
    {
        InitializeComponent();
        Started= new VehiculoBase();
        one = new Pick_Up();
        two = new Sedan();
        three = new SUV();
        four = new _4x4();
        propiedades();
    }
    private void propiedades()
    {
        relleno.Text = "Bienvenido a Vehiculos Castillo aun estamos en la gran apertura con modelos de para toda necesidad.";

        //Propiedades Base
        Started.Marca = "Honda";
        Started.Modelo = "Civic";
        Started.Color = "Azul";
        Started.Anio = 2005;
        Started.Placa = "P735SÑQ";
        Started.Tipo = "Manual";

        //Pick up
        one.Marca = "Ford";
        one.Modelo = "F250";
        one.Color = "Negro";
        one.Anio = 2021;
        one.Placa = "P908KFF";
        one.Tipo = "Manual";
        one.Llantas = "4x4";
        one.Motor = "Diesel";
        one.Radio = "Musica: Chop Suey";
        one.CapacidadCarga = "1100 kg";

        //Sedan
        two.Marca = "Mitsubishi";
        two.Modelo = "Mirage G4";
        two.Color = "Gris";
        two.Anio = 2017;
        two.Placa = "P001SPQ";
        two.Tipo = "Automatico";
        two.Tablero = "Posee tablero interactivo";
        two.Sillones = "Trae 5 asientos";
        two.AireAcondicionado = "Trae aire acondicionado";

        //SUV
        three.Marca = "Ford";
        three.Modelo = "Explorer";
        three.Color = "Azul";
        three.Anio = 2006;
        three.Placa = "P081GSS";
        three.Tipo = "Manual";
        three.Rapido = "Es un veloz";
        three.Seguro = "Es un vehiculo seguro";
        three.Robusto = "Es un vehiculo robusto";
       
        //4x4
        four.Marca = "Toyota ";
        four.Modelo = "Tundra";
        four.Color = "Negro";
        four.Anio = 2008;
        four.Placa = "P901ZDM";
        four.Tipo = "Automatico";
        four.Duro = "Es un auto Duro";
        four.Fuerte = "Es un auto Fuerte";
        four.Costoso = "Aunque no el mas barato";

        //Interfaz Base
        Marca.Text = Started.Marca;
        Modelo.Text = Started.Modelo;
        Color.Text = Started.Color;
        Anio.Text = Started.Anio.ToString();
        Placa.Text = Started.Placa;
        Tipo.Text = Started.Tipo;


        //Interfaz Pick up
        Marca2.Text = one.Marca;
        Modelo2.Text = one.Modelo;
        Color2.Text = one.Color;
        Anio2.Text = one.Anio.ToString();
        Placa2.Text = one.Placa;
        Tipo2.Text = one.Tipo;
        Llantas.Text = one.Llantas;
        Motor.Text = one.Motor;
        Radio.Text = one.Radio;

        //Interfaz Sedan
        Marca3.Text = two.Marca;
        Modelo3.Text = two.Modelo;
        Color3.Text = two.Color;
        Anio3.Text = two.Anio.ToString();
        Placa3.Text = two.Placa;
        Tipo3.Text = two.Tipo;
        Tablero.Text = two.Tablero;
        Sillones.Text = two.Sillones;
        AireAcondiconado.Text = two.AireAcondicionado;

        //Interfaz SUV
        Marca4.Text = three.Marca;
        Modelo4.Text = three.Modelo;
        Color4.Text = three.Color;
        Anio4.Text = three.Anio.ToString();
        Placa4.Text = three.Placa;
        Tipo4.Text = three.Tipo;
        Rapido.Text = three.Rapido;
        Seguro.Text = three.Seguro;
        Robusto.Text = three.Robusto;
    

        //Interfaz 4x4
        Marca5.Text = four.Marca;
        Modelo5.Text = four.Modelo;
        Color5.Text = four.Color;
        Anio5.Text = four.Anio.ToString();
        Placa5.Text = four.Placa;
        Tipo5.Text = four.Tipo;
        Duro.Text = four.Duro;
        Fuerte.Text = four.Fuerte;
        Costoso.Text = four.Costoso;

        
      

    }
    private void Bocinas_Clicked(object sender, EventArgs e)
    {
        Started.Bocina();
        if (Encendido == 1)
        {
            Form.Text = "Beep, Beep";
        }
        else
        {
            Form.Text = "  ";
        }
    }
    private void EncenderAutomovil_Clicked(object sender, EventArgs e)
    {
        Started.Encender();
        if (Encendido == 0)
        {
            Form.Text = "El vehiculo se ha encendido.";
            Encendido = 1;
        }
        else
        { Form.Text = "El vehiculo ya esta encendido"; }
    }

    private void AcelerarAutomovil_Clicked(object sender, EventArgs e)
    {
        Started.Acelerar(37);
        Started.Velocidades(37, 230);
        VelocidadActual += VelocidadActual;

        if (Encendido == 1 && (VelocidadActual <= VelocidadMaxima))
        {
            Started.Acelerar(velocidad);
            Form.Text = $"El vehiculo está acelerando a {velocidad} km/h.";
            Velocidades.Text = "La velocidad maxima es de: " + VelocidadMaxima + "km/h";
            Velocidadactual.Text = "La Velocidad actual es de: " + VelocidadActual + "km/h";
        }
        else if (Encendido == 1 && (VelocidadActual > VelocidadMaxima))
        {
            Velocidadactual.Text = "El vehiculo no puede exceder la velocidad maxima establecida";
            VelocidadActual = 130;
        }
        else
        {
            Form.Text = "El vehiculo esta apagado";
            Velocidadactual.Text = "El vehiculo no puede dar las velocidades porque esta apagado";
        }
    }
    private void Apagar_Cliked(object sender, EventArgs e)
    {
        Started.Apagar();
        if (Encendido == 1)
        {
            Form.Text = "El vehiculo se ha apagado.";
            Encendido = 0;
        }
        else
        { Form.Text = "El vehiculo ya esta apagado"; }
    }
    private void Frenar_Clicked(object sender, EventArgs e)
    {
        Started.Frenar(5);
        int cuanto = 5;
        VelocidadActual -= cuanto;
        if (Encendido == 1 && (VelocidadActual > 0))
        {
            Form.Text = $"Freno y la velocidad bajo a: {VelocidadActual} mk/h";
            Velocidadactual.Text = " ";
        }
        else
        {
            Form.Text = $"Freno y la velocidad bajo a: 0 mk/h";
            Velocidadactual.Text = " ";
        }
    }
    private void Encenderpickup(object sender, EventArgs e)
    {
        one.Encender1();
        if (Encendido2 == 0)
        {
            Form1.Text = "El Pick Up se ha encendido.";
            Encendido2 = 1;
        }
        else
        { Form1.Text = "El Pick Up ya esta encendido"; }
    }
    private void Es_4x4(object sender, EventArgs e)
    {
        one.FourWeelTraction();
        if (Encendido2 == 1)
        {
            Form1.Text = "Se puede activar la traccion 4x4";

        }
        else
        { Form1.Text = "No se activar el 4x4 porque el vehiculo esta apagado"; }
    }
    private void EncenderSedan(object sender, EventArgs e)
    {
        two.Encender();
        if (Encendido3 == 0)
        {
            two.Encender();
            Form2.Text = "El sedan se ha encendido";
            Encendido3 = 1;
        }
        else
        {
            Form2.Text = "El sedan ya esta encendido";
        }
    }
    private void Abrirbaul(object sender, EventArgs e)
    {
        if (baul == 0)
        {
            Form2.Text = "Abir baul";
            baul = 1;
        }
        else
        {
            Form2.Text = "El baul ya esta abierto";
        }
    }
    private void Cerrarbaul(object sender, EventArgs e)
    {
        if (baul == 1)
        {
            Form2.Text = "Cerrar baul";
            baul = 0;
        }
        else
        {
            Form2.Text = "El baul ya esta cerrado";
        }
    }
    private void Act_Aire_Acondicionado(object sender, EventArgs e)
    {
        if (Encendido == 1)
        {
            Form2.Text = "El aire acondicinado esta encendido";
            Encendido = 0;
        }
        else
        {
            Form2.Text = "El aire acondicionado ya esta encendido";
        }
    }
    private void Quema_Cocos(object sender, EventArgs e)
    {
        int activacion = 0;
        if (activacion == 0)
        {
            Form2.Text = "Se activo el Quema cocos disfruta del aire fresco. ";
            activacion = 1;
        }
        else
        {
            Form2.Text = "El Quema cocos esta desactivado. ";
        }
    }

    private void EncenderSUV(object sender, EventArgs e)
    {
        three.Encender();
        if (Encendido4 == 0)
        {
            Form3.Text = "Se ha encendido el SUV";
            Encendido4 = 1;
        }
        else
        {
            Form3.Text = "El vehiculo ya esta encendido";
        }
    }
    private void Abrircapo(object sender, EventArgs e)
    {
        if (capo == 0)
        {
            Form3.Text = "Abrir capo";
            capo = 1;
        }
        else
        {
            Form3.Text = "El capo ya es abierto";
        }
    }
    private void Encender4x4(object sender, EventArgs e)
    {
        four.Encender();
        if (Encendido5 == 0)
        {
            Form4.Text = "El 4x4 se ha encendido";
            Encendido5 = 1;
        }
        else
        {
            Form4.Text = "El vehiculo ya esta encendido";
        }
    }
    private void Luces(object sender, EventArgs e)
    {
        if (Encendido5 == 1)
        {
            Form4.Text = "Luces activadas";
        }
        else
        {
            Form4.Text = "No se pueden activar las luces las luces";
        }
    }
}

