# Como gerar sua chave SSH!
Criei um pequeno tutorial baseado no curso de introdução ao Git e ao Github da DIO para ajudar a configurar a sua chave SSH. :blush:

:warning:**Aviso:** o par de chaves SSH possui uma chave pública e uma chave privada. NUNCA compartilhe sua chave privada com ninguém!:warning:
## Passo-a-passo :pencil:

**OBS: estes comandos devem ser inseridos no Git Bash. Para instala-lo, basta entrar no [link](https://git-scm.com/downloads) e baixar de acordo com seu sistema operacional.**

- _ssh-keygen -t ed25519 -c "email do github"_.
 Aperte "enter" para aceitar a localização proposta ou mude o local.
 - Crie uma senha. Não se esqueça dela!
 Para verificar suas chave, use o comando:
 - cd "localização da chave". Se você não trocou a localização sugerida, escreva: _cd /c/Users/"seu nome de usuário"/.ssh/_.
 - Escreva _ls_ e, depois escreva: _cat id_ed25519.pub_
 - Pegue este valor e crie uma nova chave SSH no GitHub (profile->settings->SSH and GPG Keys).
 - Coloque este valor e um nome para esta chave.
 Após isso, volte ao Git e digite:
 - _eval $(ssh-agent -s)_
 - _ssh-add id_ed25519_ e digite sua senha criada anteriormente.