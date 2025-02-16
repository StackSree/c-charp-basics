<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>C# Timeline</title>
    <script src="https://cdn.tailwindcss.com"></script>
</head>
<body class="bg-gray-900 text-white">
    <div class="max-w-4xl mx-auto p-6">
        <h1 class="text-3xl font-bold text-center mb-6">A Brief History of C#</h1>
        <div class="relative flex flex-col items-center">
            <div class="absolute w-1 bg-blue-500 h-full left-1/2 transform -translate-x-1/2"></div>
            
            <!-- Timeline Entries -->
            <script>
                const timelineData = [
                    { year: "2024", version: "C# 12.0 (Planned)", features: ["Primary Constructors for Classes", "Collection Expressions", "Ref Readonly Parameters", "Inline Arrays", "Using Alias for Any Type"] },
                    { year: "2022", version: "C# 11.0", features: ["Generic Math Support", "Required Members", "Raw String Literals", "List Patterns", "UTF-8 String Literals"] },
                    { year: "2021", version: "C# 9.0 & 10.0", features: ["Records", "Top-level Statements", "Init-only Setters", "File-scoped Namespaces", "Constant Interpolated Strings"] },
                    { year: "2019", version: "C# 8.0", features: ["Nullable Reference Types", "Default Interface Methods", "Switch Expressions", "Async Streams", "Indices and Ranges"] },
                    { year: "2017", version: "C# 7.0-7.3", features: ["Tuples and Deconstruction", "Pattern Matching", "Local Functions", "Out Variables", "Non-trailing Named Arguments"] },
                    { year: "2015", version: "C# 6.0", features: ["Expression-bodied Members", "Null-conditional Operators", "Auto-property Initializers", "String Interpolation"] },
                    { year: "2012", version: "C# 5.0", features: ["Asynchronous Programming", "Caller Information Attributes"] },
                    { year: "2010", version: "C# 4.0", features: ["Dynamic Binding", "Named and Optional Parameters", "Generic Covariance and Contravariance"] },
                    { year: "2007", version: "C# 3.0", features: ["Implicitly Typed Variables", "Lambda Expressions", "Extension Methods", "LINQ", "Anonymous Types"] },
                    { year: "2005", version: "C# 2.0", features: ["Generics", "Anonymous Methods", "Nullable Types", "Iterators", "Partial Classes"] },
                    { year: "2002", version: "C# 1.2", features: ["Small refinements and bug fixes"] },
                    { year: "2000", version: "C# 1.0", features: ["Classes", "Structs", "Interfaces", "Delegates"] }
                ];
                
                document.addEventListener("DOMContentLoaded", () => {
                    const container = document.querySelector(".relative.flex.flex-col.items-center");
                    timelineData.forEach((entry, index) => {
                        const alignment = index % 2 === 0 ? "justify-start" : "justify-end";
                        const timelineItem = `
                            <div class='relative flex w-full mb-8 items-center ${alignment}'>
                                <div class='absolute left-1/2 transform -translate-x-1/2 bg-blue-500 p-2 rounded-full shadow-lg'></div>
                                <div class='w-1/2 flex justify-center'>
                                    <div class='bg-gray-800 text-white shadow-lg p-4 w-80 rounded-lg transform transition hover:scale-105 hover:shadow-2xl'>
                                        <h2 class='text-xl font-semibold text-blue-400'>${entry.version} (${entry.year})</h2>
                                        <ul class='list-disc list-inside mt-2 text-gray-300'>
                                            ${entry.features.map(feature => `<li>${feature}</li>`).join('')}
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        `;
                        container.insertAdjacentHTML("beforeend", timelineItem);
                    });
                });
            </script>
        </div>
    </div>
</body>
</html>
