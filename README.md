# Projet "GestionMatos"

## Présentation

La société "GestionMatos" est une entreprise de maintenance d'équipements informatiques. Elle travaille pour le compte de plusieurs sociétés (ses clients) sur divers sites. La maintenance peut être préventive (programmée à l'avance), urgente (calculée sur la base du MTBF du matériel) ou curative (suite à une panne). "GestionMatos" dispose d'un ensemble d'intervenants répartis sur toute la France.

## Objectif du Logiciel

"GestionMatos" souhaite se doter d'un logiciel pour gérer son activité d'interventions. Le logiciel sera utilisé pour gérer :
- Le matériel
- Les clients
- Les interventions prévues et réalisées

Ce logiciel, qui est accessible via un mot de passe sécurisé, doit permettre les fonctionnalités suivantes :
- Programmation d'interventions
- Validation des interventions une fois le travail terminé
- Alerte pour chaque matériel dont le MTBF depuis la dernière intervention va être atteint
- Consultation des interventions prévues et réalisées, filtrées par :
  - Client
  - Matériel
  - Type de matériel
  - Site
- Consultation de l'ensemble du matériel par :
  - Type
  - Client
  - Matériel
  - Site
  - Date de la dernière intervention
  - Durée restante avant fin du MTBF

## Spécifications

Chaque intervention possède :
- Un numéro unique d'intervention
- Une date planifiée
- Un champ commentaire
- Un matériel révisé

Chaque matériel possède :
- Un numéro de série unique
- Un client
- Un MTBF
- Une éventuelle date d’intervention
- Un nom
- Une description
- Un type
- Un site

## Technologie Utilisée

Ce logiciel sera développé en utilisant les technologies suivantes :
- Langage de programmation : C#
- Interface utilisateur : Windows Forms
- Gestion de base de données : SQL Server

