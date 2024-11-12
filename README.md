# Proje Adı: Müşteri Yönetim Sistemi (Customer Management System)

## Projenin Temel Amacı
Bu projenin amacı, e-ticaret platformlarında müşteri verilerinin yönetilmesini sağlayan bir yazılım altyapısı oluşturmaktır. Müşteri yönetim sistemi, temel CRUD (Create, Read, Update, Delete) işlemleriyle müşteri ekleme, silme, güncelleme ve listeleme işlemlerini kolayca gerçekleştirmeye olanak tanır. Bu sayede, yöneticiler müşteri bilgilerini hızlı ve verimli bir şekilde yönetebilir.

## Kullanılan Teknolojiler

### Frontend
- HTML



### Backend
- C#
- ASP.NET Core 6.0


### Veritabanı
- MSSQL


## Teknik Özellikler
**Müşteri Yönetimi CRUD İşlemleri:**
Müşteri Ekleme: Yeni müşteri bilgileri (isim, e-posta, telefon numarası, vb.) sistemde oluşturulabilir.
Müşteri Güncelleme: Var olan müşteri bilgileri üzerinde değişiklik yapılabilir (isim, adres, telefon vb. güncellenebilir).
Müşteri Silme: Hatalı veya artık geçerli olmayan müşteri bilgileri sistemden silinebilir.
Müşteri Listeleme: Sistemde kayıtlı tüm müşteriler listelenebilir. Bu liste, basit filtreleme özellikleriyle de zenginleştirilebilir (örneğin, isim, e-posta veya telefon numarasına göre filtreleme).
Service Layer (Servis Katmanı): Müşteri yönetimi işlemleri Service Layer üzerinden gerçekleştirilir. Bu katman, iş mantığını yönetir ve sistemdeki verilerin doğruluğundan sorumludur. CRUD işlemleri ICustomerService arayüzü ve ilgili sınıflar aracılığıyla yapılır.

**Repository Pattern (Veri Erişim Katmanı):** Müşteri verilerinin depolanması ve yönetilmesi için Repository Pattern kullanılır. Bu, ICustomerRepository arayüzü ile tanımlanır ve veritabanı işlemleri Entity Framework Core aracılığıyla gerçekleştirilir.

**Entity Framework Core:** Veritabanı işlemleri, Entity Framework Core ORM aracı ile yapılır. Bu sayede veritabanına yapılan işlemler, nesne yönelimli şekilde yönetilir. Müşteri verisi, Customer adlı sınıf ile temsil edilir ve tüm CRUD işlemleri bu sınıf üzerinden yapılır.

**Basit ve Anlaşılır Kod Yapısı:** Kod yapısı, SOLID prensiplerine uygun olarak yazılmıştır. Katmanlar arasında gevşek bağlılık sağlanmış, her bir katman kendi sorumluluklarına göre tasarlanmıştır. Böylece yazılımın sürdürülebilirliği ve bakımının kolaylığı sağlanmıştır.

**Veri Doğrulama:** Kullanıcıdan alınan veriler, uygun doğrulama kurallarına tabi tutulur. Örneğin, e-posta adresi doğrulaması ve telefon numarası kontrolü gibi işlemler yapılır. Hatalı veri girişleri kullanıcıya geri bildirilir.
