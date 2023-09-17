// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_IapGiftUI : Table {
  public static FB_IapGiftUI GetRootAsFB_IapGiftUI(ByteBuffer _bb) { return GetRootAsFB_IapGiftUI(_bb, new FB_IapGiftUI()); }
  public static FB_IapGiftUI GetRootAsFB_IapGiftUI(ByteBuffer _bb, FB_IapGiftUI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_IapGiftUI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string PicTitle { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string PicSlogan { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetPicBackList(int j) { int o = __offset(10); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int PicBackListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public string GetPicPriceList(int j) { int o = __offset(12); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int PicPriceListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public string GetGifeNameList(int j) { int o = __offset(14); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int GifeNameListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int Help { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_IapGiftUI> CreateFB_IapGiftUI(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset PicTitle = default(StringOffset),
      StringOffset PicSlogan = default(StringOffset),
      VectorOffset PicBackList = default(VectorOffset),
      VectorOffset PicPriceList = default(VectorOffset),
      VectorOffset GifeNameList = default(VectorOffset),
      int Help = -1) {
    builder.StartObject(7);
    FB_IapGiftUI.AddHelp(builder, Help);
    FB_IapGiftUI.AddGifeNameList(builder, GifeNameList);
    FB_IapGiftUI.AddPicPriceList(builder, PicPriceList);
    FB_IapGiftUI.AddPicBackList(builder, PicBackList);
    FB_IapGiftUI.AddPicSlogan(builder, PicSlogan);
    FB_IapGiftUI.AddPicTitle(builder, PicTitle);
    FB_IapGiftUI.AddId(builder, Id);
    return FB_IapGiftUI.EndFB_IapGiftUI(builder);
  }

  public static void StartFB_IapGiftUI(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPicTitle(FlatBufferBuilder builder, StringOffset PicTitleOffset) { builder.AddOffset(1, PicTitleOffset.Value, 0); }
  public static void AddPicSlogan(FlatBufferBuilder builder, StringOffset PicSloganOffset) { builder.AddOffset(2, PicSloganOffset.Value, 0); }
  public static void AddPicBackList(FlatBufferBuilder builder, VectorOffset PicBackListOffset) { builder.AddOffset(3, PicBackListOffset.Value, 0); }
  public static VectorOffset CreatePicBackListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartPicBackListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPicPriceList(FlatBufferBuilder builder, VectorOffset PicPriceListOffset) { builder.AddOffset(4, PicPriceListOffset.Value, 0); }
  public static VectorOffset CreatePicPriceListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartPicPriceListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGifeNameList(FlatBufferBuilder builder, VectorOffset GifeNameListOffset) { builder.AddOffset(5, GifeNameListOffset.Value, 0); }
  public static VectorOffset CreateGifeNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartGifeNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHelp(FlatBufferBuilder builder, int Help) { builder.AddInt(6, Help, -1); }
  public static Offset<FB_IapGiftUI> EndFB_IapGiftUI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftUI>(o);
  }
};

public sealed class FB_IapGiftUIContainer : Table {
  public static FB_IapGiftUIContainer GetRootAsFB_IapGiftUIContainer(ByteBuffer _bb) { return GetRootAsFB_IapGiftUIContainer(_bb, new FB_IapGiftUIContainer()); }
  public static FB_IapGiftUIContainer GetRootAsFB_IapGiftUIContainer(ByteBuffer _bb, FB_IapGiftUIContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_IapGiftUIContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_IapGiftUIContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_IapGiftUI GetItems(int j) { return GetItems(new FB_IapGiftUI(), j); }
  public FB_IapGiftUI GetItems(FB_IapGiftUI obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGiftUIContainer> CreateFB_IapGiftUIContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_IapGiftUIContainer.AddItems(builder, items);
    return FB_IapGiftUIContainer.EndFB_IapGiftUIContainer(builder);
  }

  public static void StartFB_IapGiftUIContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_IapGiftUI>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGiftUIContainer> EndFB_IapGiftUIContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftUIContainer>(o);
  }
  public static void FinishFB_IapGiftUIContainerBuffer(FlatBufferBuilder builder, Offset<FB_IapGiftUIContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
