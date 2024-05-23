wchar_t R[30]{};
std::swprintf(R, std::extent_v<decltype(R)>, L"%.17g", Number);