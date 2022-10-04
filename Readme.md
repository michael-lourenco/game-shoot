# GAME SHOOT

## Como o jogo funciona?

Waves de inimigos aparecem na tela em direção ao personagem do jogador.
O jogador deve eliminar todas as waves para passar de fase.

Durante a fase o jogador recebe moedas e pontos de experiência.

Com as moedas ele pode, durante a partida:
    - comprar aprimoramentos
    - comprar consumiveis
Com os pontos de xp ele pode:
    - fazer melhorias nas skills que possui
    - fazer melhorias nos atributos do personagem
    - comprar novas skills
    - subir de nivel do personagem

Quando estes inimigos atingem o personagem, este toma dano.
Se sua vida chegar a zero, ele morre e a fase termina.


Tasks

 - Fazer um wave game shot
 - Desenvovler o **Player**
    - Atributos:
        - nome
        - imagem em game
        - imagem na HUD
        - hp
        - stamina
        - mana
        - skills
    - Ações
        - atacar com ataque básico
        - utilizar skill
        - dar dano
        - receber dano
        - morrer
        - curar
    - o Player tem skills
    - o Player tem até 4 slots de skills ativas para utilizar
    - o Player tem 1 ataque básico
    - no primeiro momento o Player não se movimenta, ficando preso ao centro do mapa
    - para atirar deve utilizar o mouse, o ataque irá na direção do mouse
    - para utilizar uma skill, o Player deve apertar o botão do teclado referente aquela skill (no caso: q, w, e, r)
    - assim que apertar o botão, a skill será ativada
    - se for uma skill de pontaria, a mesma seguirá a posição do mouse como referência.

 - Desenvolver o Inimigo
 - Desenvolver waves
 - Desenvolver as **Skills**
    - Sistema de Skills
        - Existe um script base de onde todas as skills derivam: **SkillBlueprint** (é um ScriptableObject)
        - Uma Skill possui os seguintes atributos por padrão:
            - **skillGameObject** - objeto que é instanciado quando a skill é ativada;
            - **skillName** - nome da skill;
            - **attack** - dano base da skill;
            - **force** - força aplicada para definir a velocidade do projétil;
            - **cooldownTime** - tempo de espera necessário antes de conseguir utilizar a skill;
            - **activeTime** - tempo de duração da skill após acionada;


 - Desenvolver o inventário
 - Desenvolver a HUD
 - Desenvolver os sons
 - Desenvovler a persistência dos dados

Obs: tudo pode/deve ser alterado/aperfeiçoado ao longo do tempo