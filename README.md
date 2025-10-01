# HotelFinder API

Bu API, otel yönetimi için bir backend uygulamasıdır. Kullanıcılar otel verilerini ekleyebilir, güncelleyebilir, silebilir ve listeleyebilir. API, temel CRUD (Create, Read, Update, Delete) işlemlerini sağlar ve temiz, sürdürülebilir yazılım geliştirme pratiklerine dayanmaktadır. Bu projede, yazılım mühendisliği prensiplerine ve modern yazılım geliştirme yöntemlerine (SOLID, Dependency Injection, Asenkron Veri Erişimi vb.) tam uyum sağlanmıştır.

---

## Proje Özeti

HotelFinder API, otellerin adını, şehrini ve diğer bilgilerini saklamak için SQL Server veritabanını kullanan bir **.NET Core Web API** projesidir. API, nesne yönelimli programlama (OOP), **katmanlı mimari**, **asenkron veri erişimi**, **Dependency Injection (DI)** gibi yazılım geliştirme konseptlerine dayalı olarak inşa edilmiştir. Proje şu an için yalnızca backend kısmıyla hazırdır ve frontend tarafı ilerleyen zamanlarda eklenmesi planlanmaktadır.

Bu projede kullanılan yazılım geliştirme pratikleri ve tasarım desenleri, modern ve sürdürülebilir bir yazılım yapısının temel taşlarını oluşturur. Bu yaklaşım, yazılımın daha kolay bakımını ve genişletilmesini sağlar.

---

## Kritik Yazılım Geliştirme Pratikleri

### **Nesne Yönelimli Programlama (OOP)**
- **OOP** ilkelerine uygun bir şekilde yapılandırılmıştır. **Encapsulation** (kapsülleme), **Abstraction** (soyutlama), **Inheritance** (kalıtım) ve **Polymorphism** (çok biçimlilik) gibi temel OOP kavramları doğru bir biçimde uygulanmıştır.
- Örneğin, **IHotelService** ve **IHotelRepository** gibi arayüzler, bağımlılıklar arasında gevşek bağlılık (loose coupling) sağlar ve bu da projeyi genişletmeyi ve bakımını kolaylaştırır.

### **Katmanlı Mimari (Layered Architecture)**
- **Katmanlı mimari** ile proje, her katman için sorumlulukları net bir şekilde ayırır:
  - **API Katmanı**: HTTP isteklerini işler ve yanıtları döner.
  - **İş Katmanı (Business Layer)**: İş mantığını barındırır.
  - **Veritabanı Erişimi (Data Access Layer)**: Veritabanı işlemleri gerçekleştirilir.
  
  Bu yapı, yazılımın test edilebilirliğini ve sürdürülebilirliğini artırır. Her katman, yalnızca kendi sorumluluğuyla ilgilenir ve diğer katmanlardan bağımsız olarak geliştirilebilir.

### **SOLID Prensiplerine Uygunluk**
- Proje, **SOLID** prensiplerine uygun bir şekilde tasarlanmıştır:
  - **S**: **Single Responsibility Principle (SRP)** – Her sınıf ve metodun tek bir sorumluluğu vardır.
  - **O**: **Open/Closed Principle (OCP)** – Yeni özellikler eklerken mevcut kodda değişiklik yapmadan genişletilebilir.
  - **L**: **Liskov Substitution Principle (LSP)** – Alt sınıflar, üst sınıfların yerine geçebilir.
  - **I**: **Interface Segregation Principle (ISP)** – Gereksiz bağımlılıklar yoktur. İhtiyaç duyulan işlevler küçük, odaklanmış arayüzlerde yer alır.
  - **D**: **Dependency Inversion Principle (DIP)** – Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı değildir. Bunun yerine her ikisi de soyutlamalara bağımlıdır.

  Bu prensiplerin uygulanması, yazılımın bakımı ve genişletilmesi açısından büyük kolaylık sağlar.

### **Dependency Injection (DI)**
- **Dependency Injection** (DI) kullanılarak sınıflar arasındaki bağımlılıklar azaltılmıştır. Örneğin, **HotelManager** sınıfı, **IHotelRepository** gibi bağımlılıklarını DI aracılığıyla alır. Bu da sınıfların daha esnek ve test edilebilir olmasını sağlar.
- DI sayesinde, uygulama bağımlılıkları merkezi bir noktada yönetilir ve değişiklikler yalnızca bir kez yapılır.

### **Asenkron Veri Erişimi (Asynchronous Data Access)**
- **Entity Framework Core** kullanılarak veritabanı işlemleri asenkron olarak gerçekleştirilmiştir. Bu sayede API, veritabanı işlemleri sırasında engellenmez ve daha hızlı yanıt verir.
- Asenkron programlama, yüksek performans gereksinimlerini karşılamak için büyük önem taşır. Veritabanı işlemleri, IO-bound işlemler olduğu için bu yaklaşım API'nin genel hızını artırır.

### **Temel Ama Değerli Bir Web API Tasarımı**
- Proje, modern yazılım geliştirme pratiklerine uygun olarak **RESTful API** standartlarını takip eder.
- Her işlem için doğru HTTP yöntemleri (GET, POST, PUT, DELETE) kullanılır, uygun HTTP durum kodları döndürülür (200 OK, 201 Created, 404 Not Found).
- Swagger entegrasyonu ile API'nin dokümantasyonu otomatik olarak oluşturulmuştur, böylece geliştiriciler API'yi kolayca keşfedebilir.

---

## Proje Yapısı

- **HotelFinder.API**: API katmanı, Controller'lar ve HTTP isteklerini yönetir.
- **HotelFinder.Business**: İş mantığını barındırır. Servisler ve iş kuralları burada tanımlıdır.
- **HotelFinder.DataAccess**: Veritabanı erişimi sağlar. Repository ve veritabanı işlemleri burada yapılır.
- **HotelFinder.Entities**: Veritabanı modelleri ve veri yapıları burada yer alır.

---

## Teknolojiler

- **ASP.NET Core**: API'nin geliştirilmesinde kullanılan framework.
- **Entity Framework Core**: Veritabanı işlemleri için ORM (Object-Relational Mapper).
- **SQL Server**: Veritabanı yönetim sistemi.
- **Swagger**: API dokümantasyon ve test araçları için kullanılmıştır.

---

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen şu adımları takip edin:
1. Bu repoyu fork edin.
2. Yeni bir branch oluşturun (`git checkout -b feature/featureName`).
3. Değişikliklerinizi yapın ve commit edin.
4. Pull request açarak katkınızı gönderin.

---

## İletişim

- **E-posta**: atesanil8@gmail.com
- **GitHub**: [https://github.com/OguzAnilAtes](https://github.com/OguzAnilAtes)

---

### **Proje Değeri**

Bu proje, modern yazılım geliştirme pratiklerine uygun şekilde yapılandırılmıştır. Nesne yönelimli programlama, katmanlı mimari, SOLID prensiplerine uygunluk, asenkron veri erişimi ve dependency injection gibi tekniklerle geliştirilmiştir. Bu projede kullanılan yöntemler, yazılımın uzun vadede bakımını kolaylaştırırken, genişletilebilirlik ve test edilebilirlik açısından önemli avantajlar sağlar.
