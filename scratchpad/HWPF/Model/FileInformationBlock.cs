/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

using NPOI.HWPF.Model.Types;
using System.Collections;
using NPOI.HWPF.Model.IO;
namespace NPOI.HWPF.Model
{

    /**
     * The File Information Block (FIB). Holds pointers
     *  to various bits of the file, and lots of flags which
     *  specify properties of the document.
     *
     * The parent class, {@link FIBAbstractType}, holds the
     *  first 32 bytes, which make up the FibBase.
     * The next part, the fibRgW / FibRgW97, is handled
     *  by {@link FIBshortHandler}.
     * The next part, the fibRgLw / The FibRgLw97, is
     *  handled by the {@link FIBLongHandler}.
     * Finally, the rest of the fields are handled by
     *  the {@link FIBFieldHandler}.
     *
     * @author  andy
     */
    public class FileInformationBlock : FIBAbstractType
    {


        FIBLongHandler _longHandler;
        FIBshortHandler _shortHandler;
        FIBFieldHandler _fieldHandler;

        /** Creates a new instance of FileInformationBlock */
        public FileInformationBlock(byte[] mainDocument)
        {
            FillFields(mainDocument, 0);
        }

        public void FillVariableFields(byte[] mainDocument, byte[] tableStream)
        {
            ArrayList fieldSet = new ArrayList();
            fieldSet.Add(FIBFieldHandler.STSHF);
            fieldSet.Add(FIBFieldHandler.CLX);
            fieldSet.Add(FIBFieldHandler.DOP);
            fieldSet.Add(FIBFieldHandler.PLCFBTECHPX);
            fieldSet.Add(FIBFieldHandler.PLCFBTEPAPX);
            fieldSet.Add(FIBFieldHandler.PLCFSED);
            fieldSet.Add(FIBFieldHandler.PLCFLST);
            fieldSet.Add(FIBFieldHandler.PLFLFO);
            fieldSet.Add(FIBFieldHandler.PLCFFLDMOM);
            fieldSet.Add(FIBFieldHandler.STTBFFFN);
            fieldSet.Add(FIBFieldHandler.STTBFRMARK);
            fieldSet.Add(FIBFieldHandler.STTBSAVEDBY);
            fieldSet.Add(FIBFieldHandler.MODIFIED);


            _shortHandler = new FIBshortHandler(mainDocument);
            _longHandler = new FIBLongHandler(mainDocument, FIBshortHandler.START + _shortHandler.SizeInBytes());
            _fieldHandler = new FIBFieldHandler(mainDocument,
                                                FIBshortHandler.START + _shortHandler.SizeInBytes() + _longHandler.SizeInBytes(),
                                                tableStream, fieldSet, true);
        }

        public int GetFcDop()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.DOP);
        }

        public void SetFcDop(int fcDop)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.DOP, fcDop);
        }

        public int GetLcbDop()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.DOP);
        }

        public void SetLcbDop(int lcbDop)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.DOP, lcbDop);
        }

        public int GetFcStshf()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.STSHF);
        }

        public int GetLcbStshf()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.STSHF);
        }

        public void SetFcStshf(int fcStshf)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.STSHF, fcStshf);
        }

        public void SetLcbStshf(int lcbStshf)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.STSHF, lcbStshf);
        }

        public int GetFcClx()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.CLX);
        }

        public int GetLcbClx()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.CLX);
        }

        public void SetFcClx(int fcClx)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.CLX, fcClx);
        }

        public void SetLcbClx(int lcbClx)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.CLX, lcbClx);
        }

        public int GetFcPlcfbteChpx()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCFBTECHPX);
        }

        public int GetLcbPlcfbteChpx()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCFBTECHPX);
        }

        public void SetFcPlcfbteChpx(int fcPlcfBteChpx)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLCFBTECHPX, fcPlcfBteChpx);
        }

        public void SetLcbPlcfbteChpx(int lcbPlcfBteChpx)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLCFBTECHPX, lcbPlcfBteChpx);
        }

        public int GetFcPlcfbtePapx()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCFBTEPAPX);
        }

        public int GetLcbPlcfbtePapx()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCFBTEPAPX);
        }

        public void SetFcPlcfbtePapx(int fcPlcfBtePapx)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLCFBTEPAPX, fcPlcfBtePapx);
        }

        public void SetLcbPlcfbtePapx(int lcbPlcfBtePapx)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLCFBTEPAPX, lcbPlcfBtePapx);
        }

        public int GetFcPlcfsed()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCFSED);
        }

        public int GetLcbPlcfsed()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCFSED);
        }

        public void SetFcPlcfsed(int fcPlcfSed)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLCFSED, fcPlcfSed);
        }

        public void SetLcbPlcfsed(int lcbPlcfSed)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLCFSED, lcbPlcfSed);
        }

        public int GetFcPlcfLst()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCFLST);
        }

        public int GetLcbPlcfLst()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCFLST);
        }

        public void SetFcPlcfLst(int fcPlcfLst)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLCFLST, fcPlcfLst);
        }

        public void SetLcbPlcfLst(int lcbPlcfLst)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLCFLST, lcbPlcfLst);
        }

        public int GetFcPlfLfo()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLFLFO);
        }

        public int GetLcbPlfLfo()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLFLFO);
        }

        public void SetFcPlfLfo(int fcPlfLfo)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLFLFO, fcPlfLfo);
        }

        public void SetLcbPlfLfo(int lcbPlfLfo)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLFLFO, lcbPlfLfo);
        }

        public int GetFcSttbfffn()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.STTBFFFN);
        }

        public int GetLcbSttbfffn()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.STTBFFFN);
        }

        public void SetFcSttbfffn(int fcSttbFffn)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.STTBFFFN, fcSttbFffn);
        }

        public void SetLcbSttbfffn(int lcbSttbFffn)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.STTBFFFN, lcbSttbFffn);
        }

        public int GetFcSttbfRMark()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.STTBFRMARK);
        }

        public int GetLcbSttbfRMark()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.STTBFRMARK);
        }

        public void SetFcSttbfRMark(int fcSttbfRMark)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.STTBFRMARK, fcSttbfRMark);
        }

        public void SetLcbSttbfRMark(int lcbSttbfRMark)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.STTBFRMARK, lcbSttbfRMark);
        }

        /**
         * Return the offset to the PlcfHdd, in the table stream,
         * i.e. fcPlcfHdd
         */
        public int GetPlcfHddOffset()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCFHDD);
        }
        /**
         * Return the size of the PlcfHdd, in the table stream,
         * i.e. lcbPlcfHdd
         */
        public int GetPlcfHddSize()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCFHDD);
        }
        public void SetPlcfHddOffset(int fcPlcfHdd)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLCFHDD, fcPlcfHdd);
        }
        public void SetPlcfHddSize(int lcbPlcfHdd)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLCFHDD, lcbPlcfHdd);
        }

        public int GetFcSttbSavedBy()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.STTBSAVEDBY);
        }

        public int GetLcbSttbSavedBy()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.STTBSAVEDBY);
        }

        public void SetFcSttbSavedBy(int fcSttbSavedBy)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.STTBSAVEDBY, fcSttbSavedBy);
        }

        public void SetLcbSttbSavedBy(int fcSttbSavedBy)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.STTBSAVEDBY, fcSttbSavedBy);
        }

        public int GetModifiedLow()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLFLFO);
        }

        public int GetModifiedHigh()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLFLFO);
        }

        public void SetModifiedLow(int modifiedLow)
        {
            _fieldHandler.SetFieldOffset(FIBFieldHandler.PLFLFO, modifiedLow);
        }

        public void SetModifiedHigh(int modifiedHigh)
        {
            _fieldHandler.SetFieldSize(FIBFieldHandler.PLFLFO, modifiedHigh);
        }


        /**
         * How many bytes of the main stream contain real data.
         */
        public int GetCbMac()
        {
            return _longHandler.GetLong(FIBLongHandler.CBMAC);
        }
        /**
         * Updates the count of the number of bytes in the
         * main stream which contain real data
         */
        public void SetCbMac(int cbMac)
        {
            _longHandler.SetLong(FIBLongHandler.CBMAC, cbMac);
        }

        /**
         * The count of CPs in the main document
         */
        public int GetCcpText()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPTEXT);
        }
        /**
         * Updates the count of CPs in the main document
         */
        public void SetCcpText(int ccpText)
        {
            _longHandler.SetLong(FIBLongHandler.CCPTEXT, ccpText);
        }

        /**
         * The count of CPs in the footnote subdocument
         */
        public int GetCcpFtn()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPFTN);
        }
        /**
         * Updates the count of CPs in the footnote subdocument
         */
        public void SetCcpFtn(int ccpFtn)
        {
            _longHandler.SetLong(FIBLongHandler.CCPFTN, ccpFtn);
        }

        /**
         * The count of CPs in the header story subdocument
         */
        public int GetCcpHdd()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPHDD);
        }
        /**
         * Updates the count of CPs in the header story subdocument
         */
        public void SetCcpHdd(int ccpHdd)
        {
            _longHandler.SetLong(FIBLongHandler.CCPHDD, ccpHdd);
        }

        /**
         * The count of CPs in the comments (atn) subdocument
         */
        public int GetCcpAtn()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPATN);
        }
        public int GetCcpCommentAtn()
        {
            return GetCcpAtn();
        }
        /**
         * Updates the count of CPs in the comments (atn) story subdocument
         */
        public void SetCcpAtn(int ccpAtn)
        {
            _longHandler.SetLong(FIBLongHandler.CCPATN, ccpAtn);
        }

        /**
         * The count of CPs in the end note subdocument
         */
        public int GetCcpEdn()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPEDN);
        }
        /**
         * Updates the count of CPs in the end note subdocument
         */
        public void SetCcpEdn(int ccpEdn)
        {
            _longHandler.SetLong(FIBLongHandler.CCPEDN, ccpEdn);
        }

        /**
         * The count of CPs in the main document textboxes
         */
        public int GetCcpTxtBx()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPTXBX);
        }
        /**
         * Updates the count of CPs in the main document textboxes
         */
        public void SetCcpTxtBx(int ccpTxtBx)
        {
            _longHandler.SetLong(FIBLongHandler.CCPTXBX, ccpTxtBx);
        }

        /**
         * The count of CPs in the header textboxes
         */
        public int GetCcpHdrTxtBx()
        {
            return _longHandler.GetLong(FIBLongHandler.CCPHDRTXBX);
        }
        /**
         * Updates the count of CPs in the header textboxes
         */
        public void SetCcpHdrTxtBx(int ccpTxtBx)
        {
            _longHandler.SetLong(FIBLongHandler.CCPHDRTXBX, ccpTxtBx);
        }


        public void ClearOffsetsSizes()
        {
            _fieldHandler.ClearFields();
        }

        public int GetFcPlcffldMom()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCFFLDMOM);
        }

        public int GetLcbPlcffldMom()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCFFLDMOM);
        }

        public int GetFcPlcspaMom()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.PLCSPAMOM);
        }

        public int GetLcbPlcspaMom()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.PLCSPAMOM);
        }

        public int GetFcDggInfo()
        {
            return _fieldHandler.GetFieldOffset(FIBFieldHandler.DGGINFO);
        }

        public int GetLcbDggInfo()
        {
            return _fieldHandler.GetFieldSize(FIBFieldHandler.DGGINFO);
        }

        public void WriteTo(byte[] mainStream, HWPFStream tableStream)
        {
            //HWPFOutputStream mainDocument = sys.GetStream("WordDocument");
            //HWPFOutputStream tableStream = sys.GetStream("1Table");

            base.Serialize(mainStream, 0);

            int size = base.GetSize();
            _shortHandler.Serialize(mainStream);
            _longHandler.Serialize(mainStream, size + _shortHandler.SizeInBytes());
            _fieldHandler.WriteTo(mainStream,
              base.GetSize() + _shortHandler.SizeInBytes() + _longHandler.SizeInBytes(), tableStream);

        }

        public override int GetSize()
        {
            return base.GetSize() + _shortHandler.SizeInBytes() +
              _longHandler.SizeInBytes() + _fieldHandler.SizeInBytes();
        }
        //    public Object Clone()
        //    {
        //      try
        //      {
        //        return super.Clone();
        //      }
        //      catch (CloneNotSupportedException e)
        //      {
        //        e.printStackTrace();
        //        return null;
        //      }
        //    }
    }



}