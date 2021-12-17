## Manufacturing compnay's Store management backend service

- Domain pure POCO classes [Bussinness domain]
- DB DataBase access layer
- Service application services layer

![database](domain.png)

- **Product** table: which are products which company produces (TV, Air conditioner, washing-machine, etc)

- **Model** table: models based on products (product tv, model name 43LED)

- **ItemType** table: Items (components used for model creating) type exp: DIP, SMD, PCB BOARD

- **Item** table: Items based on item type

- **Factory** table: Companies production lines, (which components will be send to use production. [`Outcome`])

- **Supplier** table: Suppliers which delivers *items* to company [`Income`]

- **Income** table: all incomes from suppliers

- **Outcome** table: all outcomes to production lines

- **StoreBalance** table: items balance (status, how many left in the store)