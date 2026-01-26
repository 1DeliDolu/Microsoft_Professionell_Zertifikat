# Inventory Management System - Project Planning and Design

## Project Requirements

### Functional Requirements
- Add products (name, price, stock quantity)
- Update stock (sale or restock)
- View all products (name, price, stock)
- Remove products
- Update price

### Non-Functional Requirements
- Easy-to-use console menu
- Input validation with clear error messages
- Able to list at least 1000 products smoothly
- Data integrity (stock cannot be negative)

## Project Objectives
- Complete core features within 1 week
- Improve input validation and error messages within 2 weeks
- Manually test the full menu flow before submission

## Design Outline
- Data model: `Product` (Name, Price, Quantity)
- Data structure: `List<Product> inventory`
- Modules / Methods:
  - `AddProduct()` adds a product
  - `UpdateStock()` processes sale or restock
  - `UpdatePrice()` updates price
  - `ViewProducts()` lists all products
  - `RemoveProduct()` removes a product
  - Helper methods: `FindProductByName`, `ReadInt`, `ReadDecimal`
- Control structures:
  - `switch` for menu selection
  - `if/else` for input and stock checks
- Loops:
  - `while` menu loop
  - `for/foreach` listing and searching

## Tasks and Code Components
- Add product: `AddProduct()` + `ReadRequiredString` + `ReadDecimal` + `ReadInt`
- Update stock: `UpdateStock()` + `switch` + `if/else`
- List products: `ViewProducts()` + `for` loop
- Remove product: `RemoveProduct()` + `if/else`
- Update price: `UpdatePrice()` + `if/else`

## Flow Diagram (ASCII)
```
Start
  |
  v
Show menu -> Get selection
  |
  +--> [1] Add product ----> AddProduct() --+
  |                                        |
  +--> [2] Update stock -> UpdateStock() ---+
  |                                        |
  +--> [3] List products -> ViewProducts --+
  |                                        |
  +--> [4] Remove product -> RemoveProduct-+
  |                                        |
  +--> [5] Update price -> UpdatePrice() --+
  |                                        |
  +--> [0] Exit -> End                     |
  |                                        |
  +--> [Other] Invalid -> Message -> Menu -+
```

## Implementation
- Code: `6_Module/InventoryManagementApp/Program.cs`
- Required criteria:
  - At least one control structure (if/else and switch) used
  - At least one loop (while and for) used
  - Methods defined and called
