Online Alışveriş Platformu
Bu proje, bir çevrimiçi alışveriş platformu oluşturmak amacıyla geliştirilmiştir. Müşteriler ürünleri inceleyip sipariş verebilirken, adminler ise ürün ve sipariş yönetimi yapabilir. Proje, modern web uygulamalarında yaygın olarak kullanılan teknolojiler ve özelliklerle donatılmıştır.

İçindekiler
Projenin Amacı
Özellikler
Kullanılan Teknolojiler
Kurulum
Kullanım
API Endpoint’leri
Yapılacaklar
Projenin Amacı
Bu projede, müşteri ve admin rollerine sahip kullanıcıların bir alışveriş platformunda ihtiyaç duyabileceği özellikler sunulmaktadır. JWT ile kimlik doğrulama, kullanıcı yetkilendirme, middleware ile loglama ve bakım modu gibi özellikler ile güvenli, performanslı ve kullanıcı dostu bir alışveriş deneyimi sağlanması amaçlanmıştır.

Özellikler
JWT Authentication ve Authorization: Güvenli kimlik doğrulama ve yetkilendirme.
Middleware:
LoggingMiddleware: Gelen tüm istekleri loglar.
MaintenanceMiddleware: Bakım modunda tüm isteklere "Site bakımda" mesajı döner.
Data Protection: Kullanıcı şifreleri güvenli bir şekilde saklanır.
Global Exception Handling: Beklenmeyen hatalar merkezi olarak yakalanır ve yönetilir.
Kullanılan Teknolojiler
ASP.NET Core Web API
Entity Framework Core (Code First Yaklaşımı)
ASP.NET Core Identity
JWT (JSON Web Token) ile Authentication
Middleware
Data Protection API
