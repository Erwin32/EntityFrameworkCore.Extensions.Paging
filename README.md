# EntityFrameworkCore.Extensions.Paging

Provides IQueriable extension to grab specific pagedResult from query utilizing Skip and Take LINQ internaly.

```cs
var pagedResult = DbContext.EntitySer.Where(/* where condition */).GetPaged(pageIndex, pageSize);
```

example result:
```json
{
 
}
```
