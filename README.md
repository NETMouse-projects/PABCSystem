# ABCNET

`ABCNET` - альтернатива модулю `PABCSystem` для всего `NET`. Ориентирована на русскоязычную аудиторию.

# Минимальные требования
`NET Framework 4.0`

# Для разработчиков
При разработке была использована `Visual Studio 2019`.

# Цель проекта
Обеспечить пользователей `PascalABC.NET` `PABCSystem`-подобным функционалом за пределами данного языка. Но, в то же время, не предоставлять множество обёрток для работы с типами `NET`, а стимулировать обучающихся изучать данную платформу.

# Идеи проекта
- Простой для изучения и использования функционал
- Краткость кода

# Гарантируется ли полная совместимость с PABCSystem?
Нет. Функционал хоть и похожий, но отличается и по-разному распределён. Единственное место, в котором гарантируется полная совместимость - класс `ABCNET.Utils.PABCSystem`, который предоставляет часть функционала `PABCSystem` в его изначальном виде. На данный момент доступны лишь короткие функции `Lst`, `LLst`, `HSet`, `SSet`, `Dict`, `KV`.

# Не хватает функционала - что делать? 
Если Вам недостаточно предоставляемого функционала, то Вы можете:

- Запросить его реализацию здесь, либо в официальной группе поддержки
- Перейти на [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel)

# Система улучшений и исправлений
Каждая пара версий либо накапливает новый функционал, либо корректирует старый. Версии из первой категории помечаются метками с суффиксом `new`, из второй - `fix`.

Любая версия должна:
- Она должна содержать не более 15 `Issue`.
- Первые 5 `Issue` затрагивают `API` библиотеки.
- Вторые 5 `Issue` (необязательные) затрагивают примеры для `API` библиотеки.
- Третьи 5 `Issue` (необязательные) затрагивают внутренние изменения, которые не видны пользователям.
