using Refit;
using ConsumoAPIContagem.Models;

namespace ConsumoAPIContagem.Interfaces;

public interface IContagemAPI
{
    [Get("/contador")]
    Task<ResultadoContador> ObterValorAtualAsync(
        [Header("Authorization")] string token,
        [Header("Ocp-Apim-Subscription-Key")] string subscriptionKey);//,
}