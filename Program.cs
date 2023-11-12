class Program
{
    static void Main()
    {
        // Exemplo de uso
        Nokia nokiaPhone = new Nokia("123456789");
        nokiaPhone.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone("987654321");
        iphone.InstalarAplicativo("Instagram");
    }
}
