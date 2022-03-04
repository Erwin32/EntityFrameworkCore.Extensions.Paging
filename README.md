# EntityFrameworkCore.Extensions.Paging

Provides IQueriable extension to grab specific pagedResult from query utilizing Skip and Take LINQ internaly.

Entry parameters are ```pageIndex``` which is a page index 1-N and ```pageSize``` to define how many max items are on a page, default is 50.

```cs
var pagedResult = DbContext.EntitySet.Where(/* where condition */).GetPaged(pageIndex, pageSize);
```

example result:
```json
{
  "Results": [
    {
      "Id": 1,
      "Name": "Bar"
    },
    {
      "Id": 2,
      "Name": "Second Bar"
    },
    {
      "Id": 3,
      "Name": "Third Bar"
    },
    {
      "Id": 4,
      "Name": "Fourth Bar"
    },
    {
      "Id": 5,
      "Name": "Fifth Bar"
    },
    {
      "Id": 6,
      "Name": "Sixth Bar"
    },
    {
      "Id": 7,
      "Name": "Seventh Bar"
    },
    {
      "Id": 8,
      "Name": "Eight Bar"
    },
    {
      "Id": 9,
      "Name": "Ninth Bar"
    },
    {
      "Id": 10,
      "Name": "Tenth Bar"
    }
  ],
  "CurrentPage": 1,
  "PageCount": 0,
  "PageSize": 10,
  "RowCount": 14,
  "FirstRowOnPage": 1,
  "LastRowOnPage": 10
}
```
