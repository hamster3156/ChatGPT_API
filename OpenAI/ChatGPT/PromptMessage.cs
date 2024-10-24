using UnityEngine;

namespace Hamster.OpenAI.ChatGPT
{
    [CreateAssetMenu(fileName = "PromptMessage", menuName = "Scriptable Objects/PromptMessage")]
    public class PromptMessage : ScriptableObject
    {
        [SerializeField, TextArea(3, 10), Header("GPTの返答方法の指示を書く")]
        private string _promptMessage;

        public string GetPromptMessage => _promptMessage;
    }
}
