# ABCNET

`ABCNET` - альтернатива модулю `PABCSystem` для всего `NET`. Ориентирована на русскоязычную аудиторию.

# Минимальные требования
`NET Framework 4.0`

# Для разработчиков
При разработке была использована `Visual Studio 2019`.

# Цель проекта
Обеспечить пользователей `PascalABC.NET` `PABCSystem`-подобным функционалом за пределами данного языка. 

# Гарантируется ли полная совместимость с PABCSystem?
Нет. Функционал хоть и похожий, но отличается и по-разному распределён. Единственное место, в котором гарантируется полная совместимость - класс `ABCNET.Utils.PABCSystem`, который предоставляет часть функционала `PABCSystem` в его изначальном виде. На данный момент доступны лишь короткие функции `Lst`, `LLst`, `HSet`, `SSet`, `Dict`, `KV`.

# Не хватает функционала - что делать? 
Если Вам недостаточно предоставляемого функционала, то Вы можете:

- Запросить его реализацию здесь, либо в официальной группе поддержки
- Перейти на [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel)
