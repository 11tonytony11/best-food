# Best Food
This is my mid-project for one of the college courses. "Best Food" is a small restaurant that needs a simple ordering system. The system contains client GUI and kitchen GUI.

### Client Side
The client can choose a meal by category. Once a meal is chosen the client will get a meal description, cooking time, meal price, total price, etc'.

### Kitchen Side
The Kitchen side contains GUI with all pending orders and relevant details. It is also possible to see old and ready orders.

**While real restaurant requires more functionality, we were required to implement only the minimum functionality*

## Meals Table
| Code          | Category Code | Name          | Description   | Cooking Time  | Price         |
| ------------- | ------------- | ------------- | ------------- | ------------- | ------------- |
| 1             | 2             |  Beef         | Very tasty    | 30            |  139          |
| ...           | ...           |  ...          | ...           |...            |  ...          |

## Categories Table
| Category Code | Category name |
| ------------- | ------------- |
| 1             | Cakes         |
| ...           | ...           |

## Orders Table
| Code          | Food Code     | Food Name     | Category Name | Table Number  | Is ready      |
| ------------- | ------------- | ------------- | ------------- | ------------- | ------------- |
| 1             | 1             |  Beef         | Meat          | 8             |  0            |
| ...           | ...           |  ...          | ...           |...            |  ...          |
