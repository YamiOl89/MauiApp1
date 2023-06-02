using MauiApp1.Clases;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private bool sedanInfoVisible = false;
    private bool pickUpInfoVisible = false;
    private bool suvInfoVisible = false;
    private bool cuatroPorCuatroInfoVisible = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Sedan sedan = new Sedan();
            sedan.Marca = "Toyota";
            sedan.Modelo = "Corolla";
            sedan.Color = "Gris";
            sedan.Anio = 2021;
            sedan.Placa = "DEF456";
            sedan.Tipo = "Sedán";

            sedan.Encender();
            sedan.Acelerar(40);
            sedan.Bocina();
            sedan.Estacionar();
            sedan.Apagar();

            string sedanInfo = $"Marca: {sedan.Marca}\nModelo: {sedan.Modelo}\nColor: {sedan.Color}\nAño: {sedan.Anio}\nPlaca: {sedan.Placa}\nTipo: {sedan.Tipo}";
            sedanLabel.Text = sedanInfo; // Muestra la información

            sedanInfoVisible = true;
        }
    }
    private void OnCounterClicked4(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Sedan sedan = new Sedan();
            sedan.Encender();
            string sedanMethod = $"el carro esta encendido";
            sedanInfoVisible = true;
            sedanLabel.Text += sedanMethod;
        }
    }
    private void OnCounterClicked6(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Sedan sedan = new Sedan();
            sedan.Apagar();
            string sedanMethod = $"el carro esta Apagado";
            sedanLabel.Text += sedanMethod;

        }
    }
    private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUpInfoVisible = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Marca = "Ford";
            pickUp.Modelo = "Ranger";
            pickUp.Color = "Rojo";
            pickUp.Anio = 2022;
            pickUp.Placa = "ABC123";
            pickUp.Tipo = "PickUp";
            pickUp.Encender();
            pickUp.Acelerar(50);
            pickUp.Bocina();
            pickUp.Cargar();
            pickUp.Apagar();

            string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}";
            pickUpLabel.Text = pickUpInfo; // Muestra la información

            pickUpInfoVisible = true;
        }

    }
    private void OnCounterClicked5(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUpInfoVisible = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Encender();
            string picKupMethod = $"el carro esta encendido";
            pickUpLabel.Text += picKupMethod;
        }
    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            suvInfoVisible = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            SUV suv = new SUV();
            suv.Marca = "Jeep";
            suv.Modelo = "Wrangler";
            suv.Color = "Negro";
            suv.Anio = 2023;
            suv.Placa = "GHI789";
            suv.Tipo = "SUV";
            suv.Encender();
            suv.Acelerar(60);
            suv.Bocina();
            suv.ActivarTraccion4x4();
            suv.Apagar();

            string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}";
            suvLabel.Text = suvInfo; // Muestra la información

            suvInfoVisible = true;
        }
    }
    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            cuatroPorCuatroInfoVisible = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            CuatroPorCuatro cuatroPorCuatro = new CuatroPorCuatro();
            cuatroPorCuatro.Marca = "Land Rover";
            cuatroPorCuatro.Modelo = "Defender";
            cuatroPorCuatro.Color = "Verde";
            cuatroPorCuatro.Anio = 2022;
            cuatroPorCuatro.Placa = "JKL012";
            cuatroPorCuatro.Tipo = "4x4";
            cuatroPorCuatro.Encender();
            cuatroPorCuatro.Acelerar(70);
            cuatroPorCuatro.Bocina();
            cuatroPorCuatro.ConducirTerrenosDificiles();
            cuatroPorCuatro.Apagar();

            string cuatroPorCuatroInfo = $"Marca: {cuatroPorCuatro.Marca}\nModelo: {cuatroPorCuatro.Modelo}\nColor: {cuatroPorCuatro.Color}\nAño: {cuatroPorCuatro.Anio}\nPlaca: {cuatroPorCuatro.Placa}\nTipo: {cuatroPorCuatro.Tipo}";
            cuatroPorCuatroLabel.Text = cuatroPorCuatroInfo; // Muestra la información

            cuatroPorCuatroInfoVisible = true;
        }
    }

}

