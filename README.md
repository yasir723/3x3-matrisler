# 3x3 Matris İşlemleri

Bu proje, `1. sınıf bilgisayar mühendisliği öğrencisi olarak geliştirdiğim bir C# konsol uygulamasıdır`. Uygulama, **3x3 boyutunda matrislerle temel matematiksel işlemleri (çarpma, toplama, çıkarma) gerçekleştirir** ve sonucu ekranda gösterir.

## Proje Özeti

Bu uygulama, iki adet 3x3 matris üzerinde çeşitli işlemleri (çarpma, toplama, çıkarma) yapar. Kullanıcıdan matris elemanlarını alır ve sonucu ekranda gösterir. Kullanıcı, menüden seçtiği işlemi gerçekleştirir.

## Özellikler

- **Matris Çarpma:** İki matrisin çarpımını hesaplar.
- **Matris Toplama:** İki matrisin toplamını hesaplar.
- **Matris Çıkarma:** İki matrisin farkını hesaplar.
- **Kullanıcı Dostu:** Kullanıcıdan matris elemanlarını alır ve sonuçları ekranda gösterir.


## Kod Açıklaması

Aşağıda, programın temel işleyişini ve işlevlerini açıklayan kod parçaları bulunmaktadır.

### 1. Matrislerin Tanımlanması

Programın başında matrisler ve sonuç matrisi tanımlanır:

```csharp
int[,] array = new int[3, 3];
int[,] array2 = new int[3, 3];
int[,] result = new int[3, 3];
```

Bu kod parçası, iki adet 3x3 boyutunda matris (array ve array2) ve bir sonuç matrisi (result) tanımlar.

### 2. İlk Matrisin Elemanlarının Girilmesi

Kullanıcıdan ilk matrisin elemanları alınır:

```csharp
Console.WriteLine("1. Matrisin Elemanlarını Giriniz:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"[{i + 1}, {j + 1}]: ");
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
```

Bu döngüler, kullanıcıdan ilk matrisin her bir elemanını alarak array matrisine yerleştirir.

### 3. İkinci Matrisin Elemanlarının Girilmesi

İkinci matrisin elemanları da benzer şekilde kullanıcıdan alınır:

```csharp
Console.Clear();
Console.WriteLine("2. Matrisin Elemanlarını Giriniz:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"[{i + 1}, {j + 1}]: ");
        array2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
```

Bu kod parçası, ikinci matrisin elemanlarını alarak array2 matrisine yerleştirir.

### 4. İşlem Seçimi

Kullanıcı, yapmak istediği işlemi seçer:

```csharp
Console.Clear();
Console.WriteLine("İşlem Seçiniz:");
Console.WriteLine("1 - Çarpma\n2 - Toplama\n3 - Çıkarma\n4 - Bölme (Geçersiz)");
int islem = Convert.ToInt32(Console.ReadLine());
```

Bu kod parçası, kullanıcıya yapabileceği işlemleri gösterir ve seçimini alır.

### 5. Seçilen İşleme Göre Matris İşlemleri

Kullanıcı seçimine göre uygun işlem yapılır:

#### Matris Çarpma

```csharp
if (islem == 1)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < 3; k++)
            {
                result[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    Console.WriteLine("İki Matrisin Çarpımı:");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
```

Bu kod parçası, iki matrisin çarpımını hesaplar ve sonucu ekranda gösterir.

#### Matris Toplama

```csharp
else if (islem == 2)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            result[i, j] = array[i, j] + array2[i, j];
        }
    }
    Console.WriteLine("İki Matrisin Toplamı:");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
```

Bu kod parçası, iki matrisin toplamını hesaplar ve sonucu ekranda gösterir.

#### Matris Çıkarma

```csharp
else if (islem == 3)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            result[i, j] = array[i, j] - array2[i, j];
        }
    }
    Console.WriteLine("İki Matrisin Farkı:");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
```

Bu kod parçası, iki matrisin farkını hesaplar ve sonucu ekranda gösterir.

#### Geçersiz İşlem

```csharp
else if (islem == 4)
{
    Console.WriteLine("Matrisler bölünemez!");
}
```

Bu kod parçası, geçersiz bir işlem seçildiğinde kullanıcıya hata mesajı gösterir.


