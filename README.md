# APBD CW2 

## 1.

Git wykona fast-forward wtedy, gdy gałąź docelowa nie ma własnych nowych commitów i wskaźnik gałęzi może zostać po prostu przesunięty do przodu.
Merge commit powstaje wtedy, gdy obie gałęzie mają własne, niezależne commity i Git musi połączyć ich historię, zamiast tylko przesunąć wskaźnik gałęzi.

## 2.

Merge zachowuje rzeczywistą strukturę rozgałęzień i pokazuje historię pracy tak, jak faktycznie przebiegała.

Rebase przepisuje historię gałęzi roboczej, odtwarzając jej commity na szczycie zaktualizowanej gałęzi `main`.

W praktyce:
- `merge` zachowuje pełną historię rozgałęzień,
- `rebase` porządkuje historię i sprawia, że jest bardziej liniowa.

## 3.

Konflikt został wywołany przez zmodyfikowanie tego samego fragmentu kodu w dwóch różnych gałęziach.
Rozwiązanie konfliktu polegało na ręcznym przeanalizowaniu obu wersji zmiany i pozostawieniu jednej końcowej wersji, która zachowuje sens obu modyfikacji i jednocześnie nie psuje działania programu.

