# Protocolo HTTP

**Definição**: Rege as diretrizes das mensagens, comunicação e transferência de dados na Web. É **stateless**, ou seja, o servidor não armazena estado do cliente, apenas responde de acordo com a solicitação.


# Arquitetura :computer: :repeat: :file_folder:
Client-Servidor: 

- **Cliente**: browser implementa o HTTP
     -  Mensagens: Request HTTP - solicita ou envia algum dado.
     -  Foca na interface e interação com o usuário.
- **Servidor**: host dos objetos Web (tudo o que compõe a página requisitada).
	- Mensagens: Response HTTP.
	- Foca em responder e nas operações necessárias para seu funcionamento.
- **Comunicação via TCP**: pode ser ou não persistente (após a resposta do servidor a comunicação é finalizada).


# Tipos de mensagens

_Request_ e _Response_.

### Estrutura Request
- Request Line: método HTTP e versão do protocolo.
- Header Line:
	- **Host**: URL do site.
	- **Connection**: Tipo de conexão.
	- **User-Agent**: Browser que realizou a requisição.
	- **Accept-language**: linguagem requisitada pelo cliente.
- Outro campo: **Entitiy Body**.
	- NÃO utilizada pelo método GET, mas SIM pelo método POST (envio de dados).

#### Métodos seguros: 
GET, HEAD e OPTION: não mudam de estado.

### Estrutura Response
- Status Line: status code (OK, Not Found, Bad Request...) e versão do protocolo.
- Header Line:
	- **Connection**: Tipo de conexão.
	- **Data**: Quando os dados foram requiridos.
	- **Servidor**: Pasta.
	- **Last-Modified**: Cache- armazena informações sobre a página. Se a página foi alterada e essa modificação não está no cliente, a página é modificada.
	- **Content-Lenght**: tamanho do conteúdo.
	- **Content-Type**: tipo do conteúdo.
- Outro campo: **Entitiy Body**.
	- NÃO utilizada pelo método GET, mas SIM pelo método POST (envio de dados).

# Cookies

Identificação do usuário. Rastreamento (restrição ou fornecimento de funções).
- Publicidade de acordo com as preferências do cliente.
## Componentes
- Cookie Header line: response and request message.
- Cookie file: mantido no cliente (browser gerencia) e servidor.
- Banco de dados Back-End: Web Site.

# Conceitos básicos de segurança

## Criptografia por chave :key:

Exemplo: um arquivo não pode ser modificado/lido por algumas pessoas, ou seja, você precisa proteger estes dados de certas pessoas. **A chave mistura estes dados e somente ela pode transformar novamente estes dados para se tornarem legíveis.**

### Chave assimétrica :closed_lock_with_key:
Composta por uma chave privada e uma chave pública
 - Chave privada: Assinatura.
 - Chave pública: verificação de autenticidade.

### Chave simétrica (utilizado pelo SSL que é utilizado na versão segura do HTTP) :closed_lock_with_key:

Apenas uma chave privada.

#### Tipos de criptografia simétricas

- Cifra de César: trocar uma letra do alfabeto pela K-ésima a sua frente.
- (Hoje em dia) Cifra de fluxo: sequência de bits pseudo-aleatórios. Agora, misturamos os BITS. Bit a Bit.
-  (Hoje em dia) Cifra de bloco: é utilizada pelo SSL  e utiliza blocos de Bits. Ex: blocos de k = 64 bits.
Ex: Tendo uma sequencia original (010110001111) e k = 3, podemos permutar os blocos (010 110 001 111) -> (101 000 111 001).

## Certificado digital
Garante que uma chave pertence a uma determinada pessoa. Comprovar autenticidade.
### Entidade certificadora
- Verificação de identidade: alta confiabilidade.
- Emissão de certificados: vínculo entre chave e entidade.

# Protocolo SSL (Security Socket Layer)

Segurança para conexões TCP
- **Confidencialidade**: não haja leitura dos dados
- **Integridade**: não haja edição
- **Autenticidade end-point**: ambas as pontas da conexão são fidedignas.
## Qual a sua importância?
- Proteção dos dados contra roubo e leitura.
- Privacidade.
- Confiabilidade, integridade e autenticidade.
## Operação do SLL
Ocorre em 3 fases
- **Handshake**: TCP Starts, TCP Response, TCP confirmation. Estabelecer conexão de 3 vias. Verificação de autenticidade, Master Secret Key (EMS).
- **Key Derivation**: A partir do Master Secret, são criadas 4 chaves, duas para cada um da conexão.
- **Data Transfer**: Transferência efetiva de dados. Os dados são codificados e quebrados em dados menores (precisa de verificação, Record+Mac).
# HTTPS
Proteção do SSL sobre o TCP.
- Why No HTTPS: [Site](https://whynohttps.com/).
