/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */

namespace Scrubfu.Models
{
    public class CliOption
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public bool ShouldHaveValue()
        {
            return (Constants.GetValidCommandsRequiringValues().Contains(this.Name));
        }
    }
}