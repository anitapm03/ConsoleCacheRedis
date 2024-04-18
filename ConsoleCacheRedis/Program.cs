using ConsoleCacheRedis;

Console.WriteLine("Test Cache Redis");

ServiceCacheRedis service = new ServiceCacheRedis();
List<Producto> favoritos = await
   service.GetProductosFavortos();

if (favoritos == null)
{
    Console.WriteLine("no hay favs");
}
else
{
    int i = 1;
    foreach(Producto p in favoritos)
    {
        Console.WriteLine(i + " - " + p.Nombre);
        i += 1;
    }
}
Console.WriteLine("yata");
