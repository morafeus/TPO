# Lab_04 Test Cases
## https://www.litres.ru/audioknigi/

**AAA_04_1** Регистрация на сайте  
**Краткое  описание:** проверка функционала создания нового аккаунта на сайте.  
**(Предусловие) Входные данные:** для осуществления тестового кейса предварительно необходимо нажать по иконке войти и нажать создать аккаунт
будем использовать следующие входные данные:
*аккаунт гугл, который использует пользователь*

**Шаги:**  
    1. Нажать на иконку Гугл аккаунта  
    2. В открывшемся окне выбрать аккаунт, который будет использоваться при регистрации

**Ожидаемый результат:** пользователь будет зарегестирован и войдет в аккаунт, что можно проверить по обновленному виду профиля  
![результат](firstCase.png)  
**Фактический результат:** как и ожидалось.  
**Статус:** пройден успешно.

---

**AAA_04_2** Прослушивание фрагмента аудиокниги.  
**Краткое описание:** проверка возможности прослушать фрагмент аудиокниги перед покупкой, чтобы ознакомится с голосом озвучки и темпом повествования.  
**(Предусловие) Входные данные:** для осуществления тестового кейса, пользователь должен быть авторизован под своим профилем на сайте, и перейти в раздел аудиокниги. использовать будем следующие входные данные: *аккаунт на котором не приобретена искомая аудиокнига.*

**Шаги:**  
    1. Нажать на понравившуюся аудиокнигу в списке.
    2. Нажать на кнопку слушать фрагмент  

**Ожидаемый результат:** пользователь начнет прослушивание фрагмента. а в нижней части экрана появится плашка с возможностью регулировать воспроизведение.  
![результат](secondCase2.png)  
**Фактический результат:** как и ожидалось.  
**Статус:** пройден успешно.


**AAA_04_3** Проверка работы акции для новых пользователей.  
**Краткое описание:** при создании нового аккаунта, для увеличения заинтересованности пользователя предложить ему тестовую подписку на месяц за 1 рубль.  
**(предусловие) Входные данные:** для осуществления кейса нам необходимо создать новый аккаунт, на котором ни разу не осуществлялась платная подписка на сервис. а также будем использовать входные данные: *реквизиты карты с целью перевода 1 рубля, чтобы система могла запомнить реквизиты.*

**Шаги:**
    1. с главной страницы перейти на страницу с акцией.  
    2. ввести реквизиты карты  
    3. нажать оплатить.  

**Ожидаемый результат** после заполения реквизитов карты и успешного перевода, подписка будет добавлена на аккаунт.  
![результат](thirdCase.png)  
**Фактический результат** подарочный купон успешно отображается для нового пользователя.  
**Статус** пройден успешно.

---

**AAA_04_4** Проверка добавления книги в избранное.  
**Кратное описание:** проверка работы функции избранное, для книг которые мы не планируем приобретать, но хотим отложить в особый каталог для хранения.  
**(предусловие) Входные данные:** перейти в каталог, далее выбрать понравившуюся аудиокнигу, нажать на ее профилль. входные данные: *книга не должна быть приобретена\добавлена в избранное\в корзину.*

**Шаги:**  
    1. нажать на кнопку отложить  
    2. перейти в отложенные.

**Ожидаемый результат** книга будет отображена в разделе понравившиеся для удобного перехода на ее главную страницу  
![результат](4Case.png)  
**Фактический результат** книга отображена в отоложенных  
**Статус:** пройден успешно.

---

**AAA_04_5** Проверка возможности добавления отзыва без авторизации.  
**Кратное описание:** во избежания спама и неверефицированных отзывов необходимо исключить возможность их написания.  
**(предусловие) Входные данные:** необходимо не быть авторизованным в аккаунте.

**Шаги:**  
    1. нажать на любую книгу в каталоге  
    2. нажать на отзывы.  
    3. нажать на поле с отзывом и начать заполнение.

**Ожидаемый результат** отзыв не будет добавлен.  
![результат](5Case.png)  
**Фактический результат** невозможно зайти в отзывы 
**Статус:** пройден успешно.

---

**AAA_04_6** Проверка предпросмотра книги  
**Кратное описание:** перед преобретением книги на сайте у пользователя должна быть возомжность предпросмотра, для тех кому интересно ознакомится с первыми главами.    
**(предусловие) Входные данные:** необходимо быть авторизованным в аккаунте.

**Шаги:**  
    1. нажать на предпросмотр  
    2. нажать долистать до конца отрывка.

**Ожидаемый результат** можно ознакомится с 1-2 главами и получить предложение добавить книгу в корзину  
![результат](6Case.png)  
**Фактический результат** 2 главы доступны к прочтению, а после перехода с последней доступной страницы на следующую, появляется предложение о покупке  
**Статус:** пройден успешно.

---

**AAA_04_7** Проверка работы алгоритмов предложения к чтению.  
**Кратное описание:** список предлогаемых книг должен содержать книги на основе предпочтений пользователя.    
**(предусловие) Входные данные:** необходимо быть авторизованным в аккаунте и предварительно просмотреть минимум 10 книг в каталоге(перейти на их страницы).

**Шаги:**  
    1. нажать на раздел "что почитать?"  
    2. ознакомится со списком.

**Ожидаемый результат** список предлогаемых к прочитению произвдений будет состоять из пары уже открытых книг, книг смежных жанров и пары рандомных популярных книг.  
![результат](7Case.png)  
**Фактический результат** содержимое списка соответствует ожиданиям.  
**Статус:** пройден успешно.

---

**AAA_04_8** Проверка добавления в корзину   
**Кратное описание:** в авторизованном аккаунте по нажатию на кнопку добавить в корзину она будет добавлятся.  
**(предусловие) Входные данные:** необходимо быть авторизованным в аккаунте

**Шаги:**  
    1. нажать на книгу в каталоге  
    2. нажать на кнопку с иконкой корзины  
    3. перейти в корзину и проверить наличие.

**Ожидаемый результат** добавленая книга будет доступна к покупке в разделе корзины.  
![результат](8Case.png)  
**Фактический результат** что и ожидалось  
**Статус:** пройден успешно.

---

**AAA_04_9** Проверка работы промокодов   
**Кратное описание:** в авторизованном аккаунте попробовать ввести промокод.  
**(предусловие) Входные данные:** необходимо быть авторизованным в аккаунте. входные данные: *промокод с тематического сайта*.

**Шаги:**  
    1. нажать на раздел промокод  
    2. ввести в поле имеющийся код. 
    3. выбрать предлогаемые подарки и бонусы  
    4. подтвердить.

**Ожидаемый результат** будут получены бонусы (в примере книга и 15% скидка на след. покупку)  
![результат](9Case.png)  
**Фактический результат** что и ожидалось  
**Статус:** пройден успешно.

---

**AAA_04_10** Проверка подписки на подкаст.   
**Кратное описание:** подписаться на определенный подкаст.  
**(предусловие) Входные данные:** быть авторизованным в аккаунте

**Шаги:**  
    1. нажать на раздел подкасты  
    2. выбрать подкаст и перейти на его страницу. 
    3. нажать подписаться на уведомления.  

**Ожидаемый результат** подкаст появится в профиле  
![результат](10Case.png)  
**Фактический результат** подкаст не появился в списке подкастов  
**Статус:** не пройден.