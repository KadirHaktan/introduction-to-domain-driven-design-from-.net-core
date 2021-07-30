

Domain Driven Design alakalı notlar?

Ubiquitous Language
Ortak dil**


Bounded Context?
Domain'de yer alan iş kuralları çerçevesinde mantıksal açıdan birbirleri ile en alakalı olanların bi araya gelerek gruplaştığı
ve bu grubun sorumluluklarının net belirlenmiş olduğu yapıdır


Entity & Value Object
Kendine ait unique bir kimliği olan objelere Entity
Kendine ait bir kimliği olmayanlara Value denir


Domain Driven Design bize iş mantığını servislere değil bütünüyle entitylere yığmamızı istiyor


DDD'in babası olan Eric Evans büyük ve karmaşık sistemlerdeki sorunların domainlere bölünerek,
kendi domaini içersinde çözülmesi gerektiğini savunmaktadır.Bu problemlerin çoğunun business taraf
ile teknik tarafın ortak bir dil konuşamamasından ve yazılımın doğru modellenememesinden kaynaklı
olduğunu düşünmektedir

DDD'de uygulamanın içersindeki business kuralları,mantıksal olarak domainler içersine alınır