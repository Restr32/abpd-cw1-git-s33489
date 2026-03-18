# abpd-cw1-git-s33489

dlaczego tym razem merge nie był fast-forward:
ponieważ historia gałęzi main i feature-max uległa rozbieżności
tzn przed mergem main został zmieniony i pojawił się konflikt.

1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit? 
fast-forward wykonuje się wtedy gdy gałęzie nie uległy rozbieżności a merge commit powstaje gdy jest rozieżność (obie gałęzie zmodyfikowane)
• 2. Czym w praktyce różni się merge od rebase? 
merge zapisuje pełną historię commitów, a rebase zmienia całą strukturę (przepisuje)
• 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium? 
Na początku git oznaczył miejsca rozbieżności, następnie wybierałem z której gałęzi co zostawić (a pozostałe dane zostały usunięte)
na końcu domykało się commitem