// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_UIInfo : Table {
  public static FB_UIInfo GetRootAsFB_UIInfo(ByteBuffer _bb) { return GetRootAsFB_UIInfo(_bb, new FB_UIInfo()); }
  public static FB_UIInfo GetRootAsFB_UIInfo(ByteBuffer _bb, FB_UIInfo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_UIInfo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Path { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GroupName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsMainAsset { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool DestroyOnUnload { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int Layer { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool BlurBg { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AnimationType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowJuHua { get { int o = __offset(24); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int NoShowSceneId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DiamondTabCount { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetDiamondTabDefaultSpriteList(int j) { int o = __offset(30); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int DiamondTabDefaultSpriteListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public string GetDiamondTabSelectSpriteList(int j) { int o = __offset(32); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int DiamondTabSelectSpriteListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }
  public string GetDimondTabLabelList(int j) { int o = __offset(34); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int DimondTabLabelListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDimondTabFunctionIdList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DimondTabFunctionIdListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public string GetCommonTitleTextList(int j) { int o = __offset(38); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int CommonTitleTextListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMoreInfoTitleIdList(int j) { int o = __offset(40); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MoreInfoTitleIdListLength { get { int o = __offset(40); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMoreInfoContentIdList(int j) { int o = __offset(42); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MoreInfoContentIdListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }
  public bool BFullPanel { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_UIInfo> CreateFB_UIInfo(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Path = default(StringOffset),
      int Type = -1,
      StringOffset GroupName = default(StringOffset),
      bool IsMainAsset = false,
      bool DestroyOnUnload = true,
      int Layer = -1,
      bool BlurBg = false,
      int AnimationType = -1,
      bool IsShowJuHua = false,
      int NoShowSceneId = -1,
      int DiamondTabCount = -1,
      VectorOffset DiamondTabDefaultSpriteList = default(VectorOffset),
      VectorOffset DiamondTabSelectSpriteList = default(VectorOffset),
      VectorOffset DimondTabLabelList = default(VectorOffset),
      VectorOffset DimondTabFunctionIdList = default(VectorOffset),
      VectorOffset CommonTitleTextList = default(VectorOffset),
      VectorOffset MoreInfoTitleIdList = default(VectorOffset),
      VectorOffset MoreInfoContentIdList = default(VectorOffset),
      bool bFullPanel = false) {
    builder.StartObject(21);
    FB_UIInfo.AddMoreInfoContentIdList(builder, MoreInfoContentIdList);
    FB_UIInfo.AddMoreInfoTitleIdList(builder, MoreInfoTitleIdList);
    FB_UIInfo.AddCommonTitleTextList(builder, CommonTitleTextList);
    FB_UIInfo.AddDimondTabFunctionIdList(builder, DimondTabFunctionIdList);
    FB_UIInfo.AddDimondTabLabelList(builder, DimondTabLabelList);
    FB_UIInfo.AddDiamondTabSelectSpriteList(builder, DiamondTabSelectSpriteList);
    FB_UIInfo.AddDiamondTabDefaultSpriteList(builder, DiamondTabDefaultSpriteList);
    FB_UIInfo.AddDiamondTabCount(builder, DiamondTabCount);
    FB_UIInfo.AddNoShowSceneId(builder, NoShowSceneId);
    FB_UIInfo.AddAnimationType(builder, AnimationType);
    FB_UIInfo.AddLayer(builder, Layer);
    FB_UIInfo.AddGroupName(builder, GroupName);
    FB_UIInfo.AddType(builder, Type);
    FB_UIInfo.AddPath(builder, Path);
    FB_UIInfo.AddName(builder, Name);
    FB_UIInfo.AddId(builder, Id);
    FB_UIInfo.AddBFullPanel(builder, bFullPanel);
    FB_UIInfo.AddIsShowJuHua(builder, IsShowJuHua);
    FB_UIInfo.AddBlurBg(builder, BlurBg);
    FB_UIInfo.AddDestroyOnUnload(builder, DestroyOnUnload);
    FB_UIInfo.AddIsMainAsset(builder, IsMainAsset);
    return FB_UIInfo.EndFB_UIInfo(builder);
  }

  public static void StartFB_UIInfo(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(2, PathOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddGroupName(FlatBufferBuilder builder, StringOffset GroupNameOffset) { builder.AddOffset(4, GroupNameOffset.Value, 0); }
  public static void AddIsMainAsset(FlatBufferBuilder builder, bool IsMainAsset) { builder.AddBool(5, IsMainAsset, false); }
  public static void AddDestroyOnUnload(FlatBufferBuilder builder, bool DestroyOnUnload) { builder.AddBool(6, DestroyOnUnload, true); }
  public static void AddLayer(FlatBufferBuilder builder, int Layer) { builder.AddInt(7, Layer, -1); }
  public static void AddBlurBg(FlatBufferBuilder builder, bool BlurBg) { builder.AddBool(8, BlurBg, false); }
  public static void AddAnimationType(FlatBufferBuilder builder, int AnimationType) { builder.AddInt(9, AnimationType, -1); }
  public static void AddIsShowJuHua(FlatBufferBuilder builder, bool IsShowJuHua) { builder.AddBool(10, IsShowJuHua, false); }
  public static void AddNoShowSceneId(FlatBufferBuilder builder, int NoShowSceneId) { builder.AddInt(11, NoShowSceneId, -1); }
  public static void AddDiamondTabCount(FlatBufferBuilder builder, int DiamondTabCount) { builder.AddInt(12, DiamondTabCount, -1); }
  public static void AddDiamondTabDefaultSpriteList(FlatBufferBuilder builder, VectorOffset DiamondTabDefaultSpriteListOffset) { builder.AddOffset(13, DiamondTabDefaultSpriteListOffset.Value, 0); }
  public static VectorOffset CreateDiamondTabDefaultSpriteListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDiamondTabDefaultSpriteListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDiamondTabSelectSpriteList(FlatBufferBuilder builder, VectorOffset DiamondTabSelectSpriteListOffset) { builder.AddOffset(14, DiamondTabSelectSpriteListOffset.Value, 0); }
  public static VectorOffset CreateDiamondTabSelectSpriteListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDiamondTabSelectSpriteListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDimondTabLabelList(FlatBufferBuilder builder, VectorOffset DimondTabLabelListOffset) { builder.AddOffset(15, DimondTabLabelListOffset.Value, 0); }
  public static VectorOffset CreateDimondTabLabelListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDimondTabLabelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDimondTabFunctionIdList(FlatBufferBuilder builder, VectorOffset DimondTabFunctionIdListOffset) { builder.AddOffset(16, DimondTabFunctionIdListOffset.Value, 0); }
  public static VectorOffset CreateDimondTabFunctionIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDimondTabFunctionIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCommonTitleTextList(FlatBufferBuilder builder, VectorOffset CommonTitleTextListOffset) { builder.AddOffset(17, CommonTitleTextListOffset.Value, 0); }
  public static VectorOffset CreateCommonTitleTextListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartCommonTitleTextListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMoreInfoTitleIdList(FlatBufferBuilder builder, VectorOffset MoreInfoTitleIdListOffset) { builder.AddOffset(18, MoreInfoTitleIdListOffset.Value, 0); }
  public static VectorOffset CreateMoreInfoTitleIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMoreInfoTitleIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMoreInfoContentIdList(FlatBufferBuilder builder, VectorOffset MoreInfoContentIdListOffset) { builder.AddOffset(19, MoreInfoContentIdListOffset.Value, 0); }
  public static VectorOffset CreateMoreInfoContentIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMoreInfoContentIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBFullPanel(FlatBufferBuilder builder, bool bFullPanel) { builder.AddBool(20, bFullPanel, false); }
  public static Offset<FB_UIInfo> EndFB_UIInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UIInfo>(o);
  }
};

public sealed class FB_UIInfoContainer : Table {
  public static FB_UIInfoContainer GetRootAsFB_UIInfoContainer(ByteBuffer _bb) { return GetRootAsFB_UIInfoContainer(_bb, new FB_UIInfoContainer()); }
  public static FB_UIInfoContainer GetRootAsFB_UIInfoContainer(ByteBuffer _bb, FB_UIInfoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_UIInfoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_UIInfoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_UIInfo GetItems(int j) { return GetItems(new FB_UIInfo(), j); }
  public FB_UIInfo GetItems(FB_UIInfo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_UIInfoContainer> CreateFB_UIInfoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_UIInfoContainer.AddItems(builder, items);
    return FB_UIInfoContainer.EndFB_UIInfoContainer(builder);
  }

  public static void StartFB_UIInfoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_UIInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_UIInfoContainer> EndFB_UIInfoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UIInfoContainer>(o);
  }
  public static void FinishFB_UIInfoContainerBuffer(FlatBufferBuilder builder, Offset<FB_UIInfoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
