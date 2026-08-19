namespace Modelos
{
    public class Articulo
    {
        public string Rubro { get; private set; }
        public string Descripcion { get; private set; }
        public decimal Largo { get; private set; }
        public decimal? Ancho { get; private set; }
        public int Stock { get; private set; }
        public decimal Precio { get; private set; }

        public Articulo(
            string rubro,
            string descripcion,
            decimal largo,
            decimal? ancho,
            int stock,
            decimal precio)
        {
            ValidarRubro(rubro);
            ValidarDescripcion(descripcion);
            ValidarLargo(largo);
            ValidarAncho(ancho);
            ValidarStock(stock);
            ValidarPrecio(precio);

            Rubro = rubro;
            Descripcion = descripcion;
            Largo = largo;
            Ancho = ancho;
            Stock = stock;
            Precio = precio;
        }

        private static void ValidarRubro(string rubro)
        {
            if (string.IsNullOrWhiteSpace(rubro))
                throw new ArgumentException("El rubro no puede estar vacío.", nameof(rubro));
        }

        private static void ValidarDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(descripcion));
        }

        private static void ValidarLargo(decimal largo)
        {
            if (largo <= 0)
                throw new ArgumentException("El largo debe ser mayor a cero.", nameof(largo));
        }

        private static void ValidarAncho(decimal? ancho)
        {
            if (ancho.HasValue && ancho.Value <= 0)
                throw new ArgumentException("El ancho debe ser mayor a cero.", nameof(ancho));
        }

        private static void ValidarStock(int stock)
        {
            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.", nameof(stock));
        }

        private static void ValidarPrecio(decimal precio)
        {
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.", nameof(precio));
        }
    }
}
