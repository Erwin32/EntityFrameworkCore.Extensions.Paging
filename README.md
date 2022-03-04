# EntityFrameworkCore.Extensions.Paging

Provides IQueriable extension to grab specific pagedResult from query utilizing Skip and Take LINQ internaly.

Entry parameters are ```pageIndex``` which is a page index 1-N and ```pageSize``` to define how many max items are on a page, default is 50.

```cs
var pagedResult = DbContext.EntitySer.Where(/* where condition */).GetPaged(pageIndex, pageSize);
```

example result:
```json
{
 
}
```
