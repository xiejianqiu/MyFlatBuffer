// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_gonggao : Table {
  public static FB_gonggao GetRootAsFB_gonggao(ByteBuffer _bb) { return GetRootAsFB_gonggao(_bb, new FB_gonggao()); }
  public static FB_gonggao GetRootAsFB_gonggao(ByteBuffer _bb, FB_gonggao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_gonggao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RightTitle { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Content { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SignatureName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SignatureDate { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool SignatureVisible { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }

  public static Offset<FB_gonggao> CreateFB_gonggao(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset RightTitle = default(StringOffset),
      StringOffset Content = default(StringOffset),
      StringOffset SignatureName = default(StringOffset),
      StringOffset SignatureDate = default(StringOffset),
      bool SignatureVisible = true) {
    builder.StartObject(7);
    FB_gonggao.AddSignatureDate(builder, SignatureDate);
    FB_gonggao.AddSignatureName(builder, SignatureName);
    FB_gonggao.AddContent(builder, Content);
    FB_gonggao.AddRightTitle(builder, RightTitle);
    FB_gonggao.AddName(builder, Name);
    FB_gonggao.AddID(builder, ID);
    FB_gonggao.AddSignatureVisible(builder, SignatureVisible);
    return FB_gonggao.EndFB_gonggao(builder);
  }

  public static void StartFB_gonggao(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddRightTitle(FlatBufferBuilder builder, StringOffset RightTitleOffset) { builder.AddOffset(2, RightTitleOffset.Value, 0); }
  public static void AddContent(FlatBufferBuilder builder, StringOffset ContentOffset) { builder.AddOffset(3, ContentOffset.Value, 0); }
  public static void AddSignatureName(FlatBufferBuilder builder, StringOffset SignatureNameOffset) { builder.AddOffset(4, SignatureNameOffset.Value, 0); }
  public static void AddSignatureDate(FlatBufferBuilder builder, StringOffset SignatureDateOffset) { builder.AddOffset(5, SignatureDateOffset.Value, 0); }
  public static void AddSignatureVisible(FlatBufferBuilder builder, bool SignatureVisible) { builder.AddBool(6, SignatureVisible, true); }
  public static Offset<FB_gonggao> EndFB_gonggao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_gonggao>(o);
  }
};

public sealed class FB_gonggaoContainer : Table {
  public static FB_gonggaoContainer GetRootAsFB_gonggaoContainer(ByteBuffer _bb) { return GetRootAsFB_gonggaoContainer(_bb, new FB_gonggaoContainer()); }
  public static FB_gonggaoContainer GetRootAsFB_gonggaoContainer(ByteBuffer _bb, FB_gonggaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_gonggaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_gonggaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_gonggao GetItems(int j) { return GetItems(new FB_gonggao(), j); }
  public FB_gonggao GetItems(FB_gonggao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_gonggaoContainer> CreateFB_gonggaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_gonggaoContainer.AddItems(builder, items);
    return FB_gonggaoContainer.EndFB_gonggaoContainer(builder);
  }

  public static void StartFB_gonggaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_gonggao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_gonggaoContainer> EndFB_gonggaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_gonggaoContainer>(o);
  }
  public static void FinishFB_gonggaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_gonggaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
