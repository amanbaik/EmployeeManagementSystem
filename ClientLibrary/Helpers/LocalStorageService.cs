using Blazored.LocalStorage;

namespace ClientLibrary.Helpers
{
    public class LocalStorageService(ILocalStorageService localSorageService)
    {
        private const string StorageKey = "authentication-token";
        public async Task<string> GetToken() => await localSorageService.GetItemAsStringAsync(StorageKey);
        public async Task SetToken(string item) => await localSorageService.SetItemAsStringAsync(StorageKey, item);
        public async Task RemoveToken() => await localSorageService.RemoveItemAsync(StorageKey);
    }
}
