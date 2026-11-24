**1. Savol: Salomlashuv xabarini chiqaring**

Parametr olmaydigan va qiymat qaytarmaydigan `ShowWelcome()` metodini yozing. Metod `C# metodlariga xush kelibsiz!` matnini chiqarsin.

| Kiritish | Kutilgan natija |
| --- | --- |
| — | `C# metodlariga xush kelibsiz!` |

**2. Savol: Ism bilan salomlashing**

`void` qaytaradigan `ShowGreeting(string name)` metodini yozing. U berilgan ism bilan salomlashuv chiqarsin.

| Kiritish: `name` | Kutilgan natija |
| --- | --- |
| `Ali` | `Salom, Ali!` |
| `Madina` | `Salom, Madina!` |

**3. Savol: Standart qiymatni qaytaring**

Parametr olmaydigan `GetPassingScore()` metodini yozing. Metod `60` qiymatini qaytarsin. Qaytgan qiymatni chaqiruvchi tomonda chiqaring.

| Kiritish | Kutilgan natija |
| --- | --- |
| — | `O'tish balli: 60` |

**4. Savol: Ikki sonni qo‘shing**

`int` qaytaradigan `Add(int first, int second)` metodini yozing. Metod ikki son yig‘indisini qaytarsin.

| Kiritish: `first`, `second` | Kutilgan natija |
| --- | --- |
| `4, 7` | `11` |
| `0, 5` | `5` |
| `-3, 3` | `0` |

**5. Savol: Buyurtma haqida xabar tuzing**

`string` qaytaradigan `CreateOrderMessage(string product, int quantity)` metodini yozing. Metod mahsulot nomi va sonini bitta xabarda qaytarsin.

| Kiritish: `product`, `quantity` | Kutilgan natija |
| --- | --- |
| `"Kitob", 2` | `Buyurtma: 2 Kitob` |
| `"Ruchka", 5` | `Buyurtma: 5 Ruchka` |

**6. Savol: Yosh va kun bo‘yicha chipta narxini aniqlang**

`int` qaytaradigan `GetTicketPrice(int age, bool isWeekend)` metodini yozing. Yosh manfiy yoki `120` dan katta bo‘lsa, darhol `-1` qaytaring. 7 yoshdan kichik bolalar bepul kiradi. Boshqa kunlarda chipta `10000` so‘m, dam olish kunlari esa `15000` so‘m. 60 yoshdan kattalarga dam olish kunidagi narxga `20%` chegirma beriladi. Chaqiruvchi tomonda `-1` natijasini `Yosh noto'g'ri`, `0` natijasini `Bepul`, qolgan natijalarni so‘mda chiqaring.

| Kiritish: `age`, `isWeekend` | Kutilgan natija |
| --- | --- |
| `-1, false` | `Yosh noto'g'ri` |
| `121, true` | `Yosh noto'g'ri` |
| `6, true` | `Bepul` |
| `7, false` | `10000` |
| `60, true` | `15000` |
| `61, true` | `12000` |

**7. Savol: Bo‘linma va qoldiqni toping**

`bool` qaytaradigan `TryDivide(int number, int divisor, out int quotient, out int remainder)` metodini yozing. Parametrlar manfiy bo‘lmagan butun sonlar. Bo‘luvchi `0` bo‘lsa, darhol `false` qaytaring va `quotient`, `remainder` parametrlarining ikkalasiga ham `0` bering. Aks holda butun sonli bo‘linma va qoldiqni hisoblab, `true` qaytaring. Chaqiruvchi tomonda metod `true` qaytarsa bo‘linma va qoldiqni, aks holda xato xabarini chiqaring.

| Kiritish: `number`, `divisor` | Kutilgan natija |
| --- | --- |
| `17, 5` | `Bo'linma: 3; Qoldiq: 2` |
| `12, 3` | `Bo'linma: 4; Qoldiq: 0` |
| `8, 0` | `Nolga bo'lish mumkin emas.` |

**8. Savol: Chegaralangan bonusni ballga qo‘shing**

Qiymat qaytarmaydigan `AddBonus(ref int score, int bonus)` metodini yozing. Ball `0–100`, bonus esa `0–30` oralig‘ida bo‘lishi kerak. Ball yoki bonus noto‘g‘ri bo‘lsa, metod darhol qaytsin va ballni o‘zgartirmasin. To‘g‘ri qiymatlarda bonusni qo‘shing, lekin ball `100` dan oshmasin. Chaqiruvchi tomonda metoddan oldingi va keyingi ballni chiqaring.

| Kiritish: `score`, `bonus` | Kutilgan natija |
| --- | --- |
| `70, 20` | `Oldin: 70; Keyin: 90` |
| `95, 10` | `Oldin: 95; Keyin: 100` |
| `40, 0` | `Oldin: 40; Keyin: 40` |
| `105, 5` | `Oldin: 105; Keyin: 105` |
| `50, -1` | `Oldin: 50; Keyin: 50` |

**9. Savol: Ombor savdosini tekshiring**

`bool` qaytaradigan `TrySellItems(ref int stock, int quantity)` metodini yozing. `stock` va `quantity` manfiy bo‘lmasin, sotiladigan miqdor ombordagi sondan oshmasin. Shartlardan biri bajarilmasa, metod darhol `false` qaytarsin va `stock` ni o‘zgartirmasin. Savdo mumkin bo‘lsa, ombordagi sonni kamaytirib, `true` qaytaring. Natijani `Muvaffaqiyat` va yangilangan `Ombordagi son` ko‘rinishida chiqaring.

| Kiritish: `stock`, `quantity` | Kutilgan natija |
| --- | --- |
| `20, 5` | `Muvaffaqiyat: True; Ombordagi son: 15` |
| `10, 10` | `Muvaffaqiyat: True; Ombordagi son: 0` |
| `10, 12` | `Muvaffaqiyat: False; Ombordagi son: 10` |
| `5, -1` | `Muvaffaqiyat: False; Ombordagi son: 5` |

**10. Savol: Uchta sonning min, max va o‘rtadagi qiymatini toping**

Qiymat qaytarmaydigan `GetNumberStats(int first, int second, int third, out int min, out int middle, out int max)` metodini yozing. Uchta sonni o‘sish tartibida joylashtirib, eng kichigini `min`, o‘rtadagini `middle`, kattasini `max` ga bering. Massiv yoki tayyor sort metodidan foydalanmang. Chaqiruvchi tomonda uchala qiymatni chiqaring.

| Kiritish: `first`, `second`, `third` | Kutilgan natija |
| --- | --- |
| `8, 3, 5` | `Eng kichik: 3; O'rtadagi: 5; Eng katta: 8` |
| `9, 2, 6` | `Eng kichik: 2; O'rtadagi: 6; Eng katta: 9` |
| `4, 4, 1` | `Eng kichik: 1; O'rtadagi: 4; Eng katta: 4` |
| `7, 7, 7` | `Eng kichik: 7; O'rtadagi: 7; Eng katta: 7` |

**11. Savol: Uchta bahoning o‘rtachasini tekshiring**

`bool` qaytaradigan `TryCalculateAverage(int first, int second, int third, out int average)` metodini yozing. Har bir baho `0–100` oralig‘ida bo‘lishi kerak. Hech bo‘lmaganda bitta baho noto‘g‘ri bo‘lsa, darhol `false` qaytaring va `average` ga `0` bering. Aks holda uchta bahoning butun sonli o‘rtachasini hisoblab, `true` qaytaring. Chaqiruvchi tomonda muvaffaqiyat holati va o‘rtachani chiqaring.

| Kiritish: `first`, `second`, `third` | Kutilgan natija |
| --- | --- |
| `80, 90, 100` | `Muvaffaqiyat: True; O'rtacha: 90` |
| `70, 71, 72` | `Muvaffaqiyat: True; O'rtacha: 71` |
| `0, 50, 100` | `Muvaffaqiyat: True; O'rtacha: 50` |
| `80, -1, 90` | `Muvaffaqiyat: False; O'rtacha: 0` |
| `80, 101, 90` | `Muvaffaqiyat: False; O'rtacha: 0` |

**12. Savol: Uch xil shakl perimetrini overload qiling**

Bir xil nomli `GetPerimeter` metodlarini overload qiling: bir parametrli metod kvadrat tomonini, ikki parametrli metod to‘g‘ri to‘rtburchak eni va bo‘yini, uch parametrli metod esa uchburchakning uch tomonini qabul qilsin. Barcha metodlar `int` qaytarsin. O‘lchamlar `1–1000000` oralig‘idagi butun sonlar bo‘lsin. O‘lchamlar belgilangan oraliqdan tashqarida bo‘lsa, `-1` qaytaring. Uchburchak uchun istalgan ikki tomon yig‘indisi uchinchi tomondan katta bo‘lishi shart; aks holda `-1` qaytaring.

| Metod chaqiruvi | Kutilgan natija |
| --- | --- |
| `GetPerimeter(4)` | `16` |
| `GetPerimeter(3, 5)` | `16` |
| `GetPerimeter(2, 7)` | `18` |
| `GetPerimeter(3, 4, 5)` | `12` |
| `GetPerimeter(1, 2, 3)` | `-1` |
| `GetPerimeter(0, 5)` | `-1` |

**13. Savol: Talaba hisobotini overload qiling**

`ShowStudent` nomli ikkita `void` metod yozing. Bir parametrli metod ismni qabul qilib `Talaba: [name]` chiqarsin. Uch parametrli metod ism, yosh va bahoni qabul qilsin. Yosh `0–120`, baho `0–100` oralig‘ida bo‘lishi kerak; qiymatlar noto‘g‘ri bo‘lsa, `Talaba ma'lumoti noto'g'ri.` chiqarib darhol qaytsin. Aks holda `Talaba: [name]; Yosh: [age]; Baho: [score]; Natija: [result]` formatida chiqaring. Baho `60` dan kam bo‘lmasa, natija `O'tdi`, aks holda `Mashq qilish kerak` bo‘lsin.

| Metod chaqiruvi | Kutilgan natija |
| --- | --- |
| `ShowStudent("Ali")` | `Talaba: Ali` |
| `ShowStudent("Sara", 18, 60)` | `Talaba: Sara; Yosh: 18; Baho: 60; Natija: O'tdi` |
| `ShowStudent("Bek", 16, 59)` | `Talaba: Bek; Yosh: 16; Baho: 59; Natija: Mashq qilish kerak` |
| `ShowStudent("Lola", 130, 80)` | `Talaba ma'lumoti noto'g'ri.` |
| `ShowStudent("Olim", 15, 101)` | `Talaba ma'lumoti noto'g'ri.` |

**14. Savol: Chegirma summali xaridni overload qiling**

`CalculateTotal` nomli ikkita `int` qaytaradigan metod yozing. Ikki parametrli metod birlik narx va miqdorni qabul qilib, chegirmasiz jami narxni hisoblasin. Narx `1–1000000`, miqdor `0–1000` oralig‘ida bo‘lsin. Uch parametrli overload esa jami narxdan chegirma summasini ayirsin. Chegirma `0` dan jami narxgacha bo‘lishi kerak. Noto‘g‘ri qiymat bo‘lsa, `-1` qaytaring. Uchinchi parametrli metod hisobni o‘zi takrorlamasin, ikki parametrli overloaddan foydalanib jami narxni olsin.

| Metod chaqiruvi | Kutilgan natija |
| --- | --- |
| `CalculateTotal(5000, 3)` | `15000` |
| `CalculateTotal(5000, 3, 2000)` | `13000` |
| `CalculateTotal(1200, 2, 400)` | `2000` |
| `CalculateTotal(5000, 0)` | `0` |
| `CalculateTotal(5000, 2, 10000)` | `-1` |
| `CalculateTotal(0, 3)` | `-1` |

**15. Savol: GeometryGuru dasturini yarating**

Konsol dasturi ishga tushishi bilan shakllarni tanlash menyusi ko‘rinsin. Foydalanuvchi shaklni raqam bilan tanlasin. Har bir shakl tanlangandan keyin yuzani yoki perimetrni hisoblash menyusi chiqsin. Tanlangan amalga mos o‘lchamlarni foydalanuvchidan so‘rang va hisoblangan natijani chiqaring. Hisoblashda quyidagi alohida metodlardan foydalaning.

Asosiy menyuda `1 - Doira`, `2 - To'g'ri to'rtburchak`, `3 - Kvadrat`, `0 - Chiqish` tanlovlari bo‘lsin. Shakl menyusida `1 - Yuza`, `2 - Perimetr`, `0 - Orqaga` ko‘rsatilsin. `0 - Orqaga` tanlovi asosiy menyuga qaytarsin; asosiy menyudagi `0 - Chiqish` dasturdan `Xayr!` xabari bilan chiqarsin. Noto‘g‘ri tanlovda `Noto'g'ri tanlov.` chiqib, tegishli menyu qayta ko‘rsatilsin. O‘lchamlar musbat sonlar bo‘lsin.

Menyularni chiqaradigan `void` qaytaruvchi `ShowMainMenu()` va `ShowCalculationMenu()` metodlarini yozing. Har bir shaklning yuzasi va perimetrini hisoblaydigan `double` qaytaruvchi alohida metodlardan foydalaning:

| Shakl | Metod | Hisoblash |
| --- | --- | --- |
| Doira | `GetCircleArea(double radius)` | `Math.PI * radius * radius` |
| Doira | `GetCirclePerimeter(double radius)` | `2 * Math.PI * radius` |
| To‘g‘ri to‘rtburchak | `GetRectangleArea(double width, double height)` | `width * height` |
| To‘g‘ri to‘rtburchak | `GetRectanglePerimeter(double width, double height)` | `2 * (width + height)` |
| Kvadrat | `GetSquareArea(double side)` | `side * side` |
| Kvadrat | `GetSquarePerimeter(double side)` | `4 * side` |

Yuza va perimetrni kasrdan keyin ikki xona bilan chiqaring. Faqat tanlangan shakl va amal uchun kerakli o‘lchamlarni so‘rang: doira uchun radius, to‘g‘ri to‘rtburchak uchun eni va bo‘yi, kvadrat uchun tomon uzunligi.

| Ketma-ket kiritishlar | Amal | Kutilgan natija |
| --- | --- | --- |
| `1`, `1`, `2`, `0`, `0` | Doira yuzasi; ortga qaytish; chiqish | `Radius: 2`; `Yuza: 12.57`; `Xayr!` |
| `1`, `2`, `2`, `0`, `0` | Doira perimetri; ortga qaytish; chiqish | `Radius: 2`; `Perimetr: 12.57`; `Xayr!` |
| `2`, `1`, `3`, `4`, `0`, `0` | To‘g‘ri to‘rtburchak yuzasi; ortga qaytish; chiqish | `Eni: 3`; `Bo'yi: 4`; `Yuza: 12.00`; `Xayr!` |
| `2`, `2`, `3`, `4`, `0`, `0` | To‘g‘ri to‘rtburchak perimetri; ortga qaytish; chiqish | `Eni: 3`; `Bo'yi: 4`; `Perimetr: 14.00`; `Xayr!` |
| `3`, `1`, `4`, `0`, `0` | Kvadrat yuzasi; ortga qaytish; chiqish | `Tomon: 4`; `Yuza: 16.00`; `Xayr!` |
| `3`, `2`, `4`, `0`, `0` | Kvadrat perimetri; ortga qaytish; chiqish | `Tomon: 4`; `Perimetr: 16.00`; `Xayr!` |
