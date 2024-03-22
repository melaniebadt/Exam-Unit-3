using System.Text.Json;
namespace Task3
{
    public class LeftRightUpDown
    {
        public void Execution()
        {
            string jsonString = File.ReadAllText("nodes.json");
            JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
            Console.WriteLine("🌸Left and right up and down, away we go🌸");

            int sum = CalculateSum(jsonDocument.RootElement);
            Console.WriteLine("Sum of all Values: " + sum);

            int deepestLevel = FindDeepestLevel(jsonDocument.RootElement);
            Console.WriteLine("Deepest Level: " + deepestLevel);

            int nodes = NumberOfNodes(jsonDocument.RootElement);
            Console.WriteLine("Number of Nodes: " + nodes);
        }
        public int CalculateSum(JsonElement jsonElement)
        {
            int sum = 0;
            CalculateSumHelper(jsonElement, ref sum);
            return sum;
        }
        private void CalculateSumHelper(JsonElement jsonElement, ref int sum)
        {
            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                if (jsonElement.TryGetProperty("value", out JsonElement valueElement))
                {
                    sum += valueElement.GetInt32();
                }

                foreach (JsonProperty property in jsonElement.EnumerateObject())
                {
                    if (property.Value.ValueKind == JsonValueKind.Object)
                    {
                        CalculateSumHelper(property.Value, ref sum);
                    }
                }
            }
        }
        public int FindDeepestLevel(JsonElement jsonElement)
        {
            return FindDeepestLevelHelper(jsonElement, 1);
        }
        private int FindDeepestLevelHelper(JsonElement jsonElement, int currentLevel)
        {
            int maxLevel = currentLevel;

            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty property in jsonElement.EnumerateObject())
                {
                    if (property.Value.ValueKind == JsonValueKind.Object)
                    {
                        int leftLevel = FindDeepestLevelHelper(property.Value, currentLevel + 1);
                        maxLevel = Math.Max(maxLevel, leftLevel);
                    }
                }
            }

            return maxLevel;
        }
        public int NumberOfNodes(JsonElement jsonElement)
        {
            int sum = 0;
            NumberOfNodesHelper(jsonElement, ref sum);
            return sum;
        }
        private void NumberOfNodesHelper(JsonElement jsonElement, ref int sum)
        {
            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                sum++;

                foreach (JsonProperty property in jsonElement.EnumerateObject())
                {
                    if (property.Value.ValueKind == JsonValueKind.Object)
                    {
                        NumberOfNodesHelper(property.Value, ref sum);
                    }
                }
            }
        }
    }
}
