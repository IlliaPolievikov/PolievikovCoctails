# PolievikovCoctails
Introduction \ Purpose
Удобная система заказа коктейлей.

Introduction \ Document conventions
Терминология ясна.

Introduction \ References

1. Бабэ, Бруно Просто и ясно о Borland C++; М.: БИНОМ, 1995. - 400 c.
2. Дейтел, Х.М.; Дейтел, П.Дж. Как программировать на С++; М.: Бином; Издание 4-е, 2005. - 390 c.
3. Джейсон, Прайс; Майк, Гандэрлой Visual C# .NET. Полное руководство; КОРОНА принт, 2004. - 960 c.
4. Нейгел, К. C# 2005 для профессионалов; Вильямс, 2006. - 763 c.
5. Рихтер, Джефри CLR via C#. Программирование на платформе Microsoft .NET Framework 2.0 на языке C#; Питер, 2007. - 656 c.
6. Робинсон, С.; Корнес, О.; Глинн, Д. и др. C# для профессионалов; М.: Лори, 2005. - 396 c.

Overall Description \ Product features

- система складається з бази даних, яка містить інгредієнти для коктелів: ( 
продукти (назва, ціна, тип(«»), кількість на складі ), тару (тип, ціна, кількість, час необхідний для повторного використання); 
користувачі (бармен(оклад, чайові, кваліфікаця), власник складу) ; 
рецепти коктелів(опціонально) 
- системи обробки замовлення коктейлю: кожен коктейль виготовляється на основі рецепту, наявності складових, та складності виготовлення; 
- системи управління складом: власник керує наявністю компонентів 


Overall Description \ Operating environment

Intel(R) Core (TM)2 Duo CPU e7500 @ 2.93GHz 2.94 GHz. OSU 8 gb. x64. Microsoft Visual Studio. MySQL

Overall Description \ Design and implementation constraints

Язык программирования - c#, база данных - MySQL

Overall Description \ User documentation
Джейсон, Прайс; Майк, Гандэрлой Visual C# .NET. Полное руководство; КОРОНА принт, 2004. - 960 c.

System features \ System feature X
Add coctails

System features \ System feature X \ Description and priority
- додавання на склад власноруч через форму, та імпортом з CSV –файлу 
- можливість додавання нових рецептів коктелів, нових складових. 
- Наявність складових які можуть замінювати один одного 
- Декілька коктейлів можуть бути замовлені одночасно, з найдорожчий має найвищий приорітет.

System features \ System feature X \ Stimulus/Response sequences
Добавленный коктейль отображается в сетке остальных коктейлей.

System features \ System feature X \ Functional requirements
Ошибок не наблюдается, фича работает правильно. 

Non functional requirements
Only Safety Requirements.

Non functional requirements \ Performance requirements
База данных должна выдерживать не менее 1000 запросов в минуту, что бы все работало нормально. 

Non functional requirements \ Software quality attributes
Должно быть покрыто хотя бы 90% кода

Non functional requirements \ Security requirements
-

Appendix A: Glossary
Все и так понятно и доступно каждому. 

Appendix B: Analysis Models
На будущее можно использовать DFD диаграммы взаимодействия и работы.

Appendix C: Issues list
На следующею версию продукта можно выпустить более качественный интерфейс и расширить базу данных.
