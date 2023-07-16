# Linql

Linql is a next generation graph api library.  It's primary goal is to provide language-native graph api integration to achieve consistency and scale across the web. 

[Read the white paper](./WhitePaper.md)  

## Unparalleled Developer Experience 

Because Linql is language-native, it is small, light-weight, and robust.  

Using Linql allows you to interact with your api with compile-time safety and full typeahead support, significantly reducing developer time in comparison to other systems.

#### **`Typescript`**

![Typescript typeahead](./assets/typeahead.ts.gif)

#### **`C#`**

![C# typeahead](./assets/typeahead.csharp.gif)

#### **`Python`**

![Python typeahead](./assets/typeahead.python.gif)
## Client Examples

#### **`C#`**
```cs 
List<string> codesICareAbout = new List<string>() { "al", "ma" };

List<State> statesICareAbout = await states
.Where(r => codesICareAbout.Select(t => t.ToUpper()).Contains(r.State_Code))
.ToListAsync();
```

#### **`Typescript`**
```typescript
this.CodesICareAbout = ["al", "ma"];
...
const statesICareAbout: Array<State> = search
.Where(r => this.CodesICareAbout.Select(t => t.ToUpper()).Contains(r.State_Code!))
.ToListAsync();

```

#### **`Python`**
```python
statesICareAbout = ["al", "ma"]
search.Where(lambda r: any(lambda x: r.State_Code in x, map(lambda t: t.upper(), statesICareAbout))).ToListAsync()
```

#### **`Java`**
```java
List<String> codesICareAbout = Arrays.asList("al", "ma");

List<State> statesICareAbout = states
.stream()
.filter(r => codesICareAbout.stream().map(t => t.toUpperCase()).collect(Collectors.toList()).contains(r))
.collect(Collectors.toList());
```

## Language Support

| Language                             | Environment | Client                                                 | Server                                           | Notes                                                                                                                                         |
| ------------------------------------ | ----------- | ------------------------------------------------------ | ------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------- |
| C#                                   |             | [Full](./C%23/Linql.Client/)                           | [Full](./C%23/Linql.Server/)                     |
| [Javascript](./Typescript/README.md) |             |                                                        |                                                  | Uses Linq emulator                                                                                                                            |
| -                                    | Node        | [Full](./Typescript/projects/linql.client-node-fetch/) | Not Started                                      | [linql.client-fetch](./Typescript/projects/linql.client-fetch/) and [linql.client-node-fetch](./Typescript/projects/linql.client-node-fetch/) |
| -                                    | Angular     | [Full](./Typescript/projects/linql.client-angular/)    | n/a                                              | Has native framework wrapper                                                                                                                  |
| -                                    | React       | [Full](./Typescript/projects/linql.client-fetch/)      | n/a                                              | Needs native framework wr apper                                                                                                               |
| -                                    | Vanilla     | [Full](./Typescript/projects/linql.client-fetch/)      | n/a                                              |
| Python                               |             | [Partially Completed](./Python/)                       | [In Progress](./Python/linql-server-sqlalchemy/) |                                                                                                                                               |
| Java                                 |             | Not Started                                            | Not Started                                      |

## Developer Support

If Linql resonates with you, `please consider supporting the project, as the entire stack is maintained by a single developer`.  

### Ethereum

```
0x50373B51Cb601827CcC1Dc5472251031d2fdBF89
```

### Open Collective
We also have an open collective if you wish to `sponsor`, `receive individualized support`, and `prioritize features`. 

### Hire Me

[LinkedIn](https://www.linkedin.com/in/kris-sodroski-60001480/)

[sodroski@bu.edu](mailto:sodroski@bu.edu)

## Acknowledgements 

Big thanks to: 
- [Jeff Bender](https://github.com/jeffbender) for his unwavering support and mentorship
- [Manjot Chahal](https://www.linkedin.com/in/manjot-chahal-96740198/) for scoping out acorn
- [Sushmita Chaudhari](https://www.linkedin.com/in/sushmitachaudhari/) for scoping out System.Text.Json in it's prerelease 
